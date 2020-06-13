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
    public partial class AddItemForm : Form, IAddItemForm
    {
        public AddItemForm()
        {
            InitializeComponent();
        }
        public string NameServiceItem => tbName.Text;
        public DateTime StartSate => dtStart.Value;
        public DateTime FinishDate => dtFinish.Value;
        public int Coun => (int)nCoef.Value;
        public double Price => Convert.ToDouble(tbPrice.Text);
        public int IdSpecification { get; }
        public BindingList<Specification> Specifications
        {
            set => cbSpecification.DataSource = value;
        }
        public Specification Specification => (Specification)cbSpecification.SelectedItem;
        

        public event EventHandler addItem
        {
            add => btnAddItem.Click += value;
            remove => btnAddItem.Click -= value;
        }

    }
}
