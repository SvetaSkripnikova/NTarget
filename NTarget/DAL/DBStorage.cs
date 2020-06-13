using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTarget.Model;

namespace NTarget.DAL
{
    public class DBStorage
    {
        public BindingList<CloseItem> CloseItems;
        public BindingList<ServiceItem> ServiceItems;
        public BindingList<Specification> Specifications;
        public BindingList<Worker> Workers;
        public NewTargetEntities context;
        public void FillCloseItems()
        {
            context = new NewTargetEntities();
            context.CloseItem.Load();
            CloseItems = new BindingList<CloseItem>();
            CloseItems = context.CloseItem.Local.ToBindingList();
        }
        public void FillServiceItems()
        {
            context = new NewTargetEntities();
            context.ServiceItem.Load();
            ServiceItems = new BindingList<ServiceItem>();
            ServiceItems = context.ServiceItem.Local.ToBindingList();
        }
        public void FillSpecifications()
        {
            context = new NewTargetEntities();
            context.Specification.Load();
            Specifications = new BindingList<Specification>();
            Specifications = context.Specification.Local.ToBindingList();
        }
        public void FillWorkers()
        {
            context = new NewTargetEntities();
            context.Worker.Load();
            Workers = new BindingList<Worker>();
            Workers = context.Worker.Local.ToBindingList();
        }
        public DBStorage()
        {
            FillCloseItems();
            FillServiceItems();
            FillSpecifications();
            FillWorkers();
        }

    }
}
