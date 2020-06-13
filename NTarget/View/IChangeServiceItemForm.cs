using NTarget.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTarget.View
{
    public interface IChangeServiceItemForm: IView
    {
        BindingList<ServiceItem> ServiceItems {set; }
        BindingList<Specification> Specifications { set; }
        ServiceItem ServiceItem { get; }
        Specification Specification { get; }
        string NameServiceItem { get; set; }
        DateTime StartSate { get; set; }
        DateTime FinishDate { get; set; }
        int Coun { get; set; }
        double Price { get; set; }

        event EventHandler ChangeItem;
        event EventHandler SelectItem;
    }
}
