using NTarget.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTarget.View
{
    public interface IAddItemForm: IView
    {
        string NameServiceItem { get; }
        DateTime StartSate { get; }
        DateTime FinishDate { get; }
        int Coun { get; }
        double Price { get; }
        //double Total { get; }
        int IdSpecification { get; }
        BindingList<Specification> Specifications { set; }
        Specification Specification { get; }
        event EventHandler addItem;
    }
}
