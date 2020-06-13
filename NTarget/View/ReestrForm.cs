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
    public partial class ReestrForm : Form, IReestrForm
    {
        public ReestrForm()
        {
            InitializeComponent();
        }
        public BindingList<CloseItem> CloseItems
        {
            get => dgvCloseItem.DataSource as BindingList<CloseItem>;
            set => dgvCloseItem.DataSource = value;
        }
        public double AllSum { 
            get => double.Parse(tbAllSum.Text); 
            set => tbAllSum.Text=Convert.ToString(value); 
        }
        public int IDCloseItem => (int)dgvCloseItem.CurrentRow.Cells[0].Value;
        public DateTime CloseDate => (DateTime)dgvCloseItem.CurrentRow.Cells[1].Value;
        public double PerformanceSum => (double)dgvCloseItem.CurrentRow.Cells[2].Value;
        public int IDWorker => (int)dgvCloseItem.CurrentRow.Cells[3].Value;
        public int IDServiceItem => (int)dgvCloseItem.CurrentRow.Cells[4].Value;
        public ServiceItem ServiceItem => (ServiceItem)dgvCloseItem.CurrentRow.Cells[5].Value;
        public Worker Worker => (Worker)dgvCloseItem.CurrentRow.Cells[6].Value;
        public DateTime StartD => (DateTime)dtp1.Value;
        public DateTime FinishD => (DateTime)dtp2.Value;

        public event EventHandler ItemDelete
        {
            add => btnDel.Click += value;
            remove => btnDel.Click -= value;
        }
        public event EventHandler ItemChange
        {
            add => btnChange.Click += value;
            remove => btnChange.Click -= value;
        }
        public event EventHandler ItemReturn
        {
            add => btnReturn.Click += value;
            remove => btnReturn.Click -= value;
        }
        public event EventHandler StartDateChange
        {
            add => dtp1.ValueChanged += value;
            remove => dtp1.ValueChanged -= value;
        }
        public event EventHandler FinishDateChange
        {
            add => dtp2.ValueChanged += value;
            remove => dtp2.ValueChanged -= value;
        }
        public event EventHandler Report
        {
            add => btnReport.Click += value;
            remove => btnReport.Click -= value;
        }

    }
}
