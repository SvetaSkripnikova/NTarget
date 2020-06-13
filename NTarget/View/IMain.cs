using NTarget.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTarget.View
{
    public interface IMain: IView
    {
        double Price { get; set; }
        BindingList<ServiceItem> ServiceItems { get; set; }
        BindingList<Worker> Workers { set; }
        Worker SelectWorker { get; }
        int SelectIDServiceItem { get; }
        string SelectNameServiceItem { get; }
        DateTime SelectStartDate { get; }
        DateTime SelectFinishDate { get; }
        int SelectCoun { get; }
        double SelectPrice { get; }
        double SelectTotal { get; }
        int SelectIDSpecification { get; }
        Worker Worker { get; }
        event EventHandler AddSI;
        event EventHandler FinishItems;
        event EventHandler SelectedWorker;
        event EventHandler MainTable;
        event EventHandler DelSI;
        event EventHandler FinishItem;
        event EventHandler AddWorker;
        event EventHandler ChangeItem;
    }
}
