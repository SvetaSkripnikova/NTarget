using NTarget.DAL;
using NTarget.Model;
using NTarget.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTarget.Presenter
{
    public class ChangeServiceItemPresenter
    {
        IChangeServiceItemForm change;
        IMain main;
        ServiceItem serviceItem = new ServiceItem();
        BindingList<ServiceItem> serviceItems = new BindingList<ServiceItem>();
        UnitOfWork UnitOfWork;
        public ChangeServiceItemPresenter(IChangeServiceItemForm ChS, IMain MF, UnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
            change = ChS;
            main = MF;
            serviceItems = UnitOfWork.RepositoryServiceItem.GetAll();
            ChS.Specifications = unitOfWork.RepositorySpecification.GetAll();
            change.ServiceItems = serviceItems;
            ChS.ChangeItem += ChangeItemClick;
            ChS.SelectItem += SelectItemClick;
            change.ShowDialog();
        }

        private void SelectItemClick(object sender, EventArgs e)
        {
            serviceItem.NameServiceItem = change.ServiceItem.NameServiceItem;
            serviceItem.StartSate = change.ServiceItem.StartSate;
            serviceItem.FinishDate = change.ServiceItem.FinishDate;
            serviceItem.Coun = change.ServiceItem.Coun;
            serviceItem.Price = change.ServiceItem.Price;
            serviceItem.Specification = change.ServiceItem.Specification;
            
            change.NameServiceItem = serviceItem.NameServiceItem;
            serviceItem.StartSate = change.StartSate;
            serviceItem.FinishDate = change.FinishDate;
            serviceItem.Coun = change.Coun;
            serviceItem.Price = change.Price;
        }

        private void ChangeItemClick(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Изменить запись?", "Изменение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr != DialogResult.Cancel)
            {
                serviceItem.NameServiceItem = change.NameServiceItem;
                serviceItem.StartSate = change.StartSate.Date;
                serviceItem.FinishDate = change.FinishDate.Date;
                serviceItem.IdSpecification = change.Specification.IdSpecification;
                serviceItem.Coun = change.Coun;
                serviceItem.Price = change.Price;
                serviceItem.IdServiceItem = change.ServiceItem.IdServiceItem;
                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.RepositoryServiceItem.Update(serviceItem);
                main.ServiceItems = null;
                main.ServiceItems = UnitOfWork.RepositoryServiceItem.GetAll();
                MessageBox.Show("Услуга изменена");
                change.Close();
            }
        }

    }
}
