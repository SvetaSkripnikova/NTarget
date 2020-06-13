using NTarget.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTarget.DAL
{
    public interface IRepositoryCloseItem : IRepository<CloseItem>
    {
        BindingList<CloseItem> GetAll();
    }
    public class RepositoryCloseItem: IRepositoryCloseItem
    {
        private DBStorage db;
        public RepositoryCloseItem(DBStorage db)
        {
            this.db = db;
        }
        public double SummCloseItem(DateTime dateTime, DateTime dateTime1)
        {
            DBStorage db = new DBStorage();
            if (dateTime<=dateTime1)
            {
                return db.CloseItems
                                .Where(x => (x.CloseDate.Date >= dateTime.Date) && (x.CloseDate.Date <= dateTime1.Date))
                                .Sum(x => x.PerformanceSum);
            }
            else
            {
                return 0;
            }
            

        }
        public BindingList<CloseItem> GetAll()
        {
            db.context.CloseItem.Load();
            return db.context.CloseItem.Local.ToBindingList();
        }
        public CloseItem Get(int IDCloseItem)
        {
            BindingList<CloseItem> closeItems = GetAll();
            foreach (CloseItem closeItem in closeItems)
            {
                if ((IDCloseItem == closeItem.IdCloseItem))
                    return closeItem;
            }
            return null;
        }
        public bool Check(int IDCloseItem)
        {
            BindingList<CloseItem> closeItems = GetAll();
            foreach (CloseItem closeItem in closeItems)
            {
                if ((IDCloseItem == closeItem.IdCloseItem))
                    return true;
            }
            return false;
        }
        public void Create(CloseItem closeItem)
        {
            if (!Check(closeItem.IdCloseItem))
            {
                db.context.CloseItem.Add(closeItem);
                db.context.SaveChanges();
            }
            else
            {
                ++closeItem.IdCloseItem;
                Create(closeItem);
            }
        }
        public void Delete(CloseItem closeItem)
        {
            if (Check(closeItem.IdCloseItem))
            {
                db.context.CloseItem.Remove(
                   db.context.CloseItem.FirstOrDefault(
                    x => (x.IdCloseItem == closeItem.IdCloseItem)));
                db.context.SaveChanges();
            }
        }
        public void Update(CloseItem closeItem)
        {
            if (Check(closeItem.IdCloseItem))
            {
                BindingList<CloseItem> closeItems = GetAll();

                foreach (CloseItem item in closeItems)
                {
                    if ((closeItem.IdCloseItem == item.IdCloseItem))
                    {
                        item.CloseDate = closeItem.CloseDate;
                        item.PerformanceSum = closeItem.PerformanceSum;
                        db.context.SaveChanges();
                    }
                }
            }
        }
    }
}
