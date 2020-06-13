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
    public partial class Main : Form, IMain
    {
        public Main()
        {
            InitializeComponent();
        }

        public double Price
        {
            get => Convert.ToDouble(tbPrice.Text);
            set => tbPrice.Text = value.ToString();
        }

        public BindingList<ServiceItem> ServiceItems
        {
            get => dgvMain.DataSource as BindingList<ServiceItem>;
            set => dgvMain.DataSource = value;
        }
        public BindingList<Worker> Workers
        {
            set => cbWorkers.DataSource = value;
        }
        public Worker SelectWorker => (Worker)cbWorkers.SelectedItem;
        public int SelectIDServiceItem => (int)dgvMain.CurrentRow.Cells[0].Value;
        public string SelectNameServiceItem => dgvMain.CurrentRow.Cells[2].Value.ToString();
        public DateTime SelectStartDate => (DateTime)dgvMain.CurrentRow.Cells[3].Value;
        public DateTime SelectFinishDate => (DateTime)dgvMain.CurrentRow.Cells[4].Value;
        public int SelectCoun => (int)dgvMain.CurrentRow.Cells[5].Value;
        public double SelectPrice => (double)dgvMain.CurrentRow.Cells[6].Value;
        public double SelectTotal => (double)dgvMain.CurrentRow.Cells[7].Value;
        public int SelectIDSpecification => (int)dgvMain.CurrentRow.Cells[8].Value;
        public Worker Worker => (Worker)dgvMain.CurrentRow.Cells[8].Value;

        public event EventHandler AddSI
        {
            add => btnAddSI.Click += value;
            remove => btnAddSI.Click -= value;
        }
        public event EventHandler FinishItems
        {
            add => btnCloseItems.Click += value;
            remove => btnCloseItems.Click -= value;
        }
        public event EventHandler SelectedWorker
        {
            add => cbWorkers.SelectedIndexChanged += value;
            remove => cbWorkers.SelectedIndexChanged -= value;
        }
        public event EventHandler MainTable
        {
            add => dgvMain.SelectionChanged += value;
            remove => dgvMain.SelectionChanged -= value;
        }
        public event EventHandler DelSI
        {
            add => btnDelSI.Click += value;
            remove => btnDelSI.Click -= value;
        }
        public event EventHandler FinishItem
        {
            add => btnDoItem.Click += value;
            remove => btnDoItem.Click -= value;
        }
        public event EventHandler AddWorker
        {
            add => btnAddWorker.Click += value;
            remove => btnAddWorker.Click -= value;
        }
        public event EventHandler ChangeItem
        {
            add => btnChangeSI.Click += value;
            remove => btnChangeSI.Click -= value;
        }
        public new void Show()
        {
            Application.Run(this);
        }


    }
}
