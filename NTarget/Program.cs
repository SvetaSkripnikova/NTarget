using NTarget.Presenter;
using NTarget.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTarget
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var presenter = new MainPresenter(new Main(), new DAL.UnitOfWork(), new DAL.DBStorage());
            presenter.Run();
        }
    }
}
