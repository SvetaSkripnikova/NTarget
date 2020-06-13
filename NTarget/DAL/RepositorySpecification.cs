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
    public interface IRepositorySpecification : IRepository<Specification>
    {
        BindingList<Specification> GetAll();
    }
    public class RepositorySpecification: IRepositorySpecification
    {
        private DBStorage db;
        public RepositorySpecification(DBStorage db)
        {
            this.db = db;
        }

        public BindingList<Specification> GetAll()
        {
            db.context.Specification.Load();
            return db.context.Specification.Local.ToBindingList();
        }

        public bool Check(int IDSpecification)
        {
            BindingList<Specification> specifications = GetAll();
            foreach (Specification specification in specifications)
            {
                if ((IDSpecification == specification.IdSpecification)) return true;
            }
            return false;
        }

        public void Create(Specification item)
        {
            throw new NotImplementedException();
        }

        public void Update(Specification item)
        {
            throw new NotImplementedException();
        }
        public void Delete(Specification item)
        {
            throw new NotImplementedException();
        }
    }
}
