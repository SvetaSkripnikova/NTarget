using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTarget.DAL
{
    public static class DBStatic
    {
        private static DBStorage dbStorage = new DBStorage();
        public static DBStorage DBStorage
        {
            get { return dbStorage; }
            set { dbStorage = value; }
        }
    }
}
