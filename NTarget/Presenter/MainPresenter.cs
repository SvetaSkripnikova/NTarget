using NTarget.DAL;
using NTarget.Model;
using NTarget.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTarget.Presenter
{
    public class MainPresenter: IMainPresenter
    {
        private IMain _mainView { get; set; }
        private double Price;
        UnitOfWork UnitOfWork;

        public void Run()
        {
            _mainView.Show();
        }
        public MainPresenter(IMain view, UnitOfWork unitOfWork, DBStorage db)
        {
            UnitOfWork = unitOfWork;
            _mainView = view;
            view.AddSI += AddSICLick;
            view.AddWorker += AddWorkerCLick;
            view.FinishItems += FinishItemsCLick;
            view.SelectedWorker += WorkerChanged;
            view.MainTable += ServiceItemChoice;
            view.DelSI += DelSI;
            view.FinishItem += FinishItemClick;
            view.ChangeItem += ChangeItemClick;
            //view.ReportShedule += ReportSheduleClick;
            //view.AddWorker += AddWorkerClick;
            view.Workers = UnitOfWork.RepositoryWorker.GetAll();
            view.ServiceItems = UnitOfWork.RepositoryServiceItem.GetAll();
        }

        private void AddWorkerClick(object sender, EventArgs e)
        {
            var tt = new AddWorkerPresenter(new AddWorkerForm(), UnitOfWork);
        }

        //private void ReportSheduleClick(object sender, EventArgs e)
        //{
        //    ExcelExportShedule export = new ExcelExportShedule();
        //    export.SetContent(UnitOfWork.RepositoryScheduleExcursionItem);
        //}

        private void FinishItemClick(object sender, EventArgs e)
        {
            CloseItem closeItem = new CloseItem();
            ServiceItem serviceItem = new ServiceItem();
            closeItem.IdServiceItem = _mainView.SelectIDServiceItem;
            closeItem.PerformanceSum = _mainView.Price;
            closeItem.CloseDate = DateTime.Now;
            closeItem.IdWorker = _mainView.Worker.IdWorker;
            serviceItem.Coun = _mainView.SelectCoun - 1;
            serviceItem.Price = _mainView.SelectPrice;
            serviceItem.Total = _mainView.SelectPrice * (_mainView.SelectCoun-1);
            serviceItem.StartSate = _mainView.SelectStartDate;
            serviceItem.FinishDate = _mainView.SelectFinishDate;
            serviceItem.NameServiceItem = _mainView.SelectNameServiceItem;
            serviceItem.IdSpecification = _mainView.SelectIDSpecification;
            serviceItem.IdServiceItem = _mainView.SelectIDServiceItem;
            if (serviceItem.Coun<0)
            {
                MessageBox.Show("Задачи по этой услуге уже выполнены. Если хотите удалить услугу из списка - удалите выполненные задачи по этой услуге из реестра");
            }
            else
            {
                UnitOfWork.RepositoryCloseItem.Create(closeItem);
                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.RepositoryServiceItem.ChoiceOperation(serviceItem.IdServiceItem, serviceItem);
                MessageBox.Show("Задача выполнена");
            }
            _mainView.ServiceItems = null;
            _mainView.ServiceItems = UnitOfWork.RepositoryServiceItem.GetAll();
        }

        private void DelSI(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить услугу?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr != DialogResult.Cancel)
            {
                ServiceItem serviceItem = new ServiceItem();
                serviceItem.Total = _mainView.SelectTotal;
                serviceItem.Price = _mainView.SelectPrice;
                serviceItem.Coun = _mainView.SelectCoun;
                serviceItem.StartSate = _mainView.SelectStartDate;
                serviceItem.FinishDate = _mainView.SelectFinishDate;
                serviceItem.NameServiceItem = _mainView.SelectNameServiceItem;
                serviceItem.IdSpecification = _mainView.SelectIDSpecification;
                serviceItem.IdServiceItem = _mainView.SelectIDServiceItem;
                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.RepositoryServiceItem.Delete(serviceItem);
                MessageBox.Show("Удаление выполнено");
                _mainView.ServiceItems = null;
                _mainView.ServiceItems = UnitOfWork.RepositoryServiceItem.GetAll();
            }
        }

        private void ChangeItemClick(object sender, EventArgs e)
        {
            var rf = new ChangeServiceItemPresenter(new ChangeServiceItemForm(), _mainView, UnitOfWork);
        }

        private void ServiceItemChoice(object sender, EventArgs e)
        {
            Price = _mainView.SelectPrice;
            _mainView.Price = _mainView.SelectPrice;
            _mainView.ServiceItems = UnitOfWork.RepositoryServiceItem.GetAll();
        }

        private void WorkerChanged(object sender, EventArgs e)
        {
            _mainView.Price = _mainView.SelectPrice * UnitOfWork.RepositoryWorker.Get(_mainView.SelectWorker);
        }

        private void AddSICLick(object sender, EventArgs e)
        {
            var rf = new AddItemPresenter(new AddItemForm(), _mainView, UnitOfWork);

        }
        private void AddWorkerCLick(object sender, EventArgs e)
        {

        }
        private void FinishItemsCLick(object sender, EventArgs e)
        {
            var form = new ReestrPresenter(new ReestrForm(), _mainView, UnitOfWork);
        }
    }
}
