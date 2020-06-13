using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTarget.DAL
{
    public class UnitOfWork
    {
        private DBStorage db = DBStatic.DBStorage;
        private RepositoryCloseItem repositoryCloseItem;
        private RepositoryServiceItem repositoryServiceItem;
        private RepositorySpecification repositorySpecification;
        private RepositoryWorker repositoryWorker;
        public RepositoryCloseItem RepositoryCloseItem
        {
            get
            {
                if (repositoryCloseItem == null)
                    repositoryCloseItem = new RepositoryCloseItem(db);
                return repositoryCloseItem;
            }
        }
        public RepositoryServiceItem RepositoryServiceItem
        {
            get
            {
                if (repositoryServiceItem == null)
                    repositoryServiceItem = new RepositoryServiceItem(db);
                return repositoryServiceItem;
            }
        }
        public RepositorySpecification RepositorySpecification
        {
            get
            {
                if (repositorySpecification == null)
                    repositorySpecification = new RepositorySpecification(db);
                return repositorySpecification;
            }
        }
        public RepositoryWorker RepositoryWorker
        {
            get
            {
                if (repositoryWorker == null)
                    repositoryWorker = new RepositoryWorker(db);
                return repositoryWorker;
            }
        }
    }
}
