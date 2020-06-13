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
    public partial class AddWorkerForm : Form, IAddWorkerForm
    {
        public AddWorkerForm()
        {
            InitializeComponent();
        }
        public string NameWorker => tbName.Text;
        public string Kvol => tbKval.Text;
        public double Coef  => (double)nCoef.Value;

        public event EventHandler addWorker
        {
            add => btnAdd.Click += value;
            remove => btnAdd.Click -= value;
        }

    }
}
