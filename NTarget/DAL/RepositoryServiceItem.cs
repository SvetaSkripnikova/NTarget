using NTarget.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTarget.DAL
{
    public interface IRepositoryServiceItem : IRepository<ServiceItem>
    {
        BindingList<ServiceItem> GetAll();
    }
    public class RepositoryServiceItem: IRepositoryServiceItem
    {
        private DBStorage db;
        public RepositoryServiceItem(DBStorage db)
        {
            this.db = db;
        }
        public int CheckOnDo(int IDServiceItem)
        {
            BindingList<ServiceItem> serviceItems = GetAll();
            foreach (ServiceItem serviceItem in serviceItems)
            {
                if ((IDServiceItem == serviceItem.IdServiceItem))
                    return (serviceItem.Coun);
            }
            return 0;
        }
        public void ChoiceOperation(int IDServiceItem, ServiceItem serviceItem)
        {
            int k = CheckOnDo(IDServiceItem);
            if (k > 0)
            {
                if (Check(serviceItem.IdServiceItem))
                {
                    BindingList<ServiceItem> serviceItems = GetAll();

                    foreach (ServiceItem item in serviceItems)
                    {
                        if ((serviceItem.IdServiceItem == item.IdServiceItem))
                        {
                            item.NameServiceItem = serviceItem.NameServiceItem;
                            item.StartSate = serviceItem.StartSate;
                            item.FinishDate = serviceItem.FinishDate;
                            item.Coun = serviceItem.Coun;
                            item.Price = serviceItem.Price;
                            item.Total = serviceItem.Total;
                            item.IdSpecification = serviceItem.IdSpecification;
                            db.context.ServiceItem.AddOrUpdate(serviceItem);
                            db.context.SaveChanges();
                        }
                    }

                }
            }
            
        }
        public BindingList<ServiceItem> GetAll()
        {
            db.context.ServiceItem.Load();
            return db.context.ServiceItem.Local.ToBindingList();
        }
        public ServiceItem Get(int IDServiceItem)
        {
            BindingList<ServiceItem> serviceItems = GetAll();
            foreach (ServiceItem serviceItem in serviceItems)
            {
                if ((IDServiceItem == serviceItem.IdServiceItem))
                    return serviceItem;
            }
            return null;
        }
        public bool Check(int IDServiceItem)
        {
            BindingList<ServiceItem> serviceItems = GetAll();
            foreach (ServiceItem serviceItem in serviceItems)
            {
                if ((IDServiceItem == serviceItem.IdServiceItem))
                    return true;
            }
            return false;
        }
        public void Create(ServiceItem serviceItem)
        {
            if (!Check(serviceItem.IdServiceItem))
            {
                db.context.ServiceItem.Add(serviceItem);
                db.context.SaveChanges();
            }
            else
            {
                ++serviceItem.IdServiceItem;
                Create(serviceItem);
            }
        }
        public void Delete(ServiceItem serviceItem)
        {
            if (Check(serviceItem.IdServiceItem))
            {
                db.context.ServiceItem.Remove(
                   db.context.ServiceItem.FirstOrDefault(
                    x => (x.IdServiceItem == serviceItem.IdServiceItem)));
                db.context.SaveChanges();
            }
        }
        public void Update(ServiceItem serviceItem)
        {
            if (Check(serviceItem.IdServiceItem))
            {
                BindingList<ServiceItem> serviceItems = GetAll();

                foreach (ServiceItem item in serviceItems)
                {
                    if ((serviceItem.IdServiceItem == item.IdServiceItem))
                    {
                        item.NameServiceItem = serviceItem.NameServiceItem;
                        item.StartSate = serviceItem.StartSate;
                        item.FinishDate = serviceItem.FinishDate;
                        item.Coun = serviceItem.Coun;
                        item.Price = serviceItem.Price;
                        item.Total = serviceItem.Total;
                        item.IdSpecification = serviceItem.IdSpecification;
                        db.context.ServiceItem.AddOrUpdate(serviceItem);
                        db.context.SaveChanges();
                    }
                }

            }
        }
    }
}
