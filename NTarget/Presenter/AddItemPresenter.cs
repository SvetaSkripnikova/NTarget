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
    public class AddItemPresenter
    {
        IAddItemForm addItemForm;
        IMain main;
        ServiceItem serviceItem = new ServiceItem();
        UnitOfWork UnitOfWork;

        public AddItemPresenter(IAddItemForm AF, IMain MF, UnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
            addItemForm = AF;
            main = MF;
            AF.Specifications = unitOfWork.RepositorySpecification.GetAll();
            AF.addItem += addItemClick;
            addItemForm.ShowDialog();
        }

        private void addItemClick(object sender, EventArgs e)
        {
            serviceItem.NameServiceItem = addItemForm.NameServiceItem;
            serviceItem.StartSate = addItemForm.StartSate.Date;
            serviceItem.FinishDate = addItemForm.FinishDate.Date;
            serviceItem.Coun = addItemForm.Coun;
            serviceItem.Price = addItemForm.Price;
            serviceItem.Total = addItemForm.Coun * addItemForm.Price;
            serviceItem.IdSpecification = addItemForm.Specification.IdSpecification;
            UnitOfWork.RepositoryServiceItem.Create(serviceItem);
            UnitOfWork.RepositoryServiceItem.Update(serviceItem);
            main.ServiceItems = null;
            main.ServiceItems = UnitOfWork.RepositoryServiceItem.GetAll();
            MessageBox.Show("Услуга создана");
            addItemForm.Close();
    }

    }
}
