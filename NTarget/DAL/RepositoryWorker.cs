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
    public interface IRepositoryWorker : IRepository<Worker>
    {
        BindingList<Worker> GetAll();
    }
    public class RepositoryWorker: IRepositoryWorker
    {
        private DBStorage db;
        public RepositoryWorker(DBStorage db)
        {
            this.db = db;
        }
        public void Create(Worker item)
        {
            if (!Check(item.IdWorker))
            {
                db.context.Worker.Add(item);
                db.context.SaveChanges();
            }
            else
            {
                ++item.IdWorker;
                Create(item);
            }
        }

        public void Delete(Worker item)
        {
            throw new NotImplementedException();
        }
        public double Get(Worker item)
        {
            if (Check(item.IdWorker))
            {
                return (double)item.Coef;
            }
            return (double)item.Coef;
        }
        public BindingList<Worker> GetAll()
        {
            db.context.Worker.Load();
            return db.context.Worker.Local.ToBindingList();
        }

        public void Update(Worker item)
        {
            throw new NotImplementedException();
        }
        public bool Check(int IDWorker)
        {
            BindingList<Worker> workers = GetAll();
            foreach (Worker worker in workers)
            {
                if ((IDWorker == worker.IdWorker)) return true;
            }
            return false;

        }
    }
}
