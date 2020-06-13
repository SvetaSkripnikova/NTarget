using NTarget.DAL;
using NTarget.Model;
using NTarget.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTarget.Presenter
{
    public class AddWorkerPresenter
    {
        IAddWorkerForm addWorkerForm;
        Worker Worker = new Worker();
        UnitOfWork UnitOfWork;

        public AddWorkerPresenter(IAddWorkerForm AF, UnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
            addWorkerForm = AF;
            AF.addWorker += addWorkerClick;
            addWorkerForm.ShowDialog();
        }

        private void addWorkerClick(object sender, EventArgs e)
        {
            Worker.NameWorker = addWorkerForm.NameWorker;
            Worker.Kvol = addWorkerForm.Kvol;
            Worker.Coef = addWorkerForm.Coef;
            UnitOfWork.RepositoryWorker.Create(Worker);
            addWorkerForm.Close();
        }

    }
}
