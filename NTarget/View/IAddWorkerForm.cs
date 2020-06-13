using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTarget.View
{
    public interface IAddWorkerForm: IView
    {
        string NameWorker { get; }
        string Kvol { get; }
        double Coef { get; }
        event EventHandler addWorker;
    }
}
