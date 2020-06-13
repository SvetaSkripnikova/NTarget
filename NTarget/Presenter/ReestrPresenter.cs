using NTarget.DAL;
using NTarget.Model;
using NTarget.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTarget.Presenter
{
    public class ReestrPresenter
    {
        IReestrForm _reestrForm;
        IMain main;
        UnitOfWork unitOfWork = new UnitOfWork();

        UnitOfWork UnitOfWork;
        public ReestrPresenter(IReestrForm RF, IMain MF, UnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
            _reestrForm = RF;
            main = MF;
            RF.CloseItems = UnitOfWork.RepositoryCloseItem.GetAll();
            RF.ItemDelete += ItemDeleteClick;
            RF.ItemChange += ItemChangeClick;
            RF.ItemReturn += ItemReturnClick;
            RF.StartDateChange += DateChangeClick;
            RF.FinishDateChange += DateChangeClick;
            //RF.ReportSellTicket += ReportSellTicketClick;
            RF.AllSum = UnitOfWork.RepositoryCloseItem.SummCloseItem(_reestrForm.StartD, _reestrForm.FinishD);
            _reestrForm.ShowDialog();
        }

        //private void ReportSellTicketClick(object sender, EventArgs e)
        //{
        //    ExcelExport export = new ExcelExport();
        //    BindingList<Ticket_sold> tickets = UnitOfWork.RepositorySellTicket.GetAllDate(_sellForm.SelectDate, _sellForm.ToSelectDate);
        //    foreach (Ticket_sold item in tickets)
        //    {
        //        ReportSellTicket reportSellTicket = new ReportSellTicket();
        //        reportSellTicket.NameExcursion = item.Name_excursion;
        //        reportSellTicket.TimeStart = (DateTime)item.DateTime_start;
        //        reportSellTicket.PriceTicket = (double)item.Price_ticket;
        //        reportSellTicket.TypeTicket = item.Type_ticket;
        //        reportSellTicket.SaleTime = item.Sale_time;
        //        reportSellTicket.Month = _sellForm.SelectDate;
        //        reportSellTicket.Summ = _sellForm.AllSalles;
        //        reportSellTicket.ToMonth = _sellForm.ToSelectDate;
        //        unitOfWork.RepositoryReportSellTicket.Create(reportSellTicket);
        //    }
        //    export.SetContent(unitOfWork.RepositoryReportSellTicket);
        //}
        private void DateChangeClick(object sender, EventArgs e)
        {
            double sum = UnitOfWork.RepositoryCloseItem.SummCloseItem(_reestrForm.StartD, _reestrForm.FinishD);
            _reestrForm.AllSum = sum;
        }

        private void ItemChangeClick(object sender, EventArgs e)
        {
            //var rf = new ChangeSellPrs(new ChangeSell(), UnitOfWork);
            //_sellForm.SellTickets = null;
            //_sellForm.SellTickets = UnitOfWork.RepositorySellTicket.GetAll();
        }

        private void ItemDeleteClick(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить выполненную услугу?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr != DialogResult.Cancel)
            {
                CloseItem closeItem = new CloseItem();
                closeItem.CloseDate = _reestrForm.CloseDate;
                closeItem.PerformanceSum = _reestrForm.PerformanceSum;
                closeItem.IdWorker = _reestrForm.IDWorker;
                closeItem.IdServiceItem = _reestrForm.IDServiceItem;
                closeItem.IdCloseItem = _reestrForm.IDCloseItem;
                UnitOfWork.RepositoryCloseItem.Delete(closeItem);
                _reestrForm.CloseItems = UnitOfWork.RepositoryCloseItem.GetAll();
                _reestrForm.AllSum = UnitOfWork.RepositoryCloseItem.SummCloseItem(_reestrForm.StartD, _reestrForm.FinishD);
            }
        }

        private void ItemReturnClick(object sender, EventArgs e)
        {
            ServiceItem serviceItem = new ServiceItem();
            CloseItem closeItem = new CloseItem();
            serviceItem.IdServiceItem = _reestrForm.IDServiceItem;
            DBStorage db = new DBStorage();
            ServiceItem test = db.ServiceItems.Where(p => p.IdServiceItem == _reestrForm.IDServiceItem).First();
            serviceItem.IdSpecification = test.IdSpecification;
            serviceItem.NameServiceItem = test.NameServiceItem;
            serviceItem.FinishDate = test.FinishDate.Date;
            serviceItem.StartSate = test.StartSate.Date;
            serviceItem.Total = test.Total+test.Price;
            serviceItem.Price = test.Price;
            serviceItem.Coun =test.Coun+1;
            UnitOfWork.RepositoryServiceItem.Update(serviceItem);
            closeItem.CloseDate = _reestrForm.CloseDate;
            closeItem.PerformanceSum = _reestrForm.PerformanceSum;
            closeItem.IdWorker = _reestrForm.IDWorker;
            closeItem.IdServiceItem = _reestrForm.IDServiceItem;
            closeItem.IdCloseItem = _reestrForm.IDCloseItem;
            UnitOfWork.RepositoryCloseItem.Delete(closeItem);
            _reestrForm.CloseItems = UnitOfWork.RepositoryCloseItem.GetAll();
            _reestrForm.AllSum = UnitOfWork.RepositoryCloseItem.SummCloseItem(_reestrForm.StartD, _reestrForm.FinishD);
            MessageBox.Show("Задача возвращена");
            main.ServiceItems = null;
            main.ServiceItems = UnitOfWork.RepositoryServiceItem.GetAll();
            _reestrForm.Close();
        }

    }
}
