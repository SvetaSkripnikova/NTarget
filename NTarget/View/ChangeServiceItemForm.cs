using NTarget.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTarget.View
{
    public partial class ChangeServiceItemForm : Form, IChangeServiceItemForm
    {
        public ChangeServiceItemForm()
        {
            InitializeComponent();
        }
        public string NameServiceItem
        {
            get => tbName.Text;
            set => tbName.Text = value;
        }
        public DateTime StartSate
        {
            get => dtStart.Value;
            set => dtStart.Value = value;
        }
        public DateTime FinishDate
        {
            get => dtFinish.Value;
            set => dtFinish.Value = value;
        }
        public int Coun 
        {
            get => (int)nCoef.Value;
            set => nCoef.Value = (int)value;
        }
        public double Price
        {
            get => (double)tbPrice.Value;
            set => tbPrice.Value = (decimal)value;
        }

        public Specification Specification
        {
            get => (Specification)cbSpecification.SelectedItem;
        }
        public BindingList<Specification> Specifications
        {
            set => cbSpecification.DataSource = value;
        }
        public ServiceItem ServiceItem
        {
            get => (ServiceItem)cbItem.SelectedItem;
        }
        public BindingList<ServiceItem> ServiceItems
        {
            set => cbItem.DataSource = value;
        }

        public event EventHandler SelectItem
        {
            add => cbItem.SelectedIndexChanged += value;
            remove => cbItem.SelectedIndexChanged -= value;
        }

        public event EventHandler ChangeItem
        {
            add => btnEditItem.Click += value;
            remove => btnEditItem.Click -= value;
        }

    }
}
