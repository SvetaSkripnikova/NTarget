using NTarget.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTarget.View
{
    public interface IReestrForm: IView
    {
        double AllSum { get; set; }
        BindingList<CloseItem> CloseItems { get; set; }
        int IDCloseItem { get; }
        DateTime CloseDate { get; }
        double PerformanceSum { get; }
        int IDWorker { get; }
        int IDServiceItem { get; }
        DateTime StartD { get; }
        DateTime FinishD { get; }
        ServiceItem ServiceItem { get; }
        Worker Worker { get; }

        event EventHandler ItemDelete;
        event EventHandler ItemChange;
        event EventHandler ItemReturn;
        event EventHandler StartDateChange;
        event EventHandler FinishDateChange;
        event EventHandler Report;

    }
}
