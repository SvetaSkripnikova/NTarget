namespace NTarget.View
{
    partial class ReestrForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvCloseItem = new System.Windows.Forms.DataGridView();
            this.closeItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnChange = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDel = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReport = new System.Windows.Forms.ToolStripMenuItem();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAllSum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idCloseItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.performanceSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idWorkerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idServiceItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCloseItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeItemBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCloseItem
            // 
            this.dgvCloseItem.AutoGenerateColumns = false;
            this.dgvCloseItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCloseItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCloseItemDataGridViewTextBoxColumn,
            this.closeDateDataGridViewTextBoxColumn,
            this.performanceSumDataGridViewTextBoxColumn,
            this.idWorkerDataGridViewTextBoxColumn,
            this.idServiceItemDataGridViewTextBoxColumn,
            this.serviceItemDataGridViewTextBoxColumn,
            this.workerDataGridViewTextBoxColumn});
            this.dgvCloseItem.DataSource = this.closeItemBindingSource;
            this.dgvCloseItem.Location = new System.Drawing.Point(12, 138);
            this.dgvCloseItem.Name = "dgvCloseItem";
            this.dgvCloseItem.Size = new System.Drawing.Size(776, 300);
            this.dgvCloseItem.TabIndex = 0;
            // 
            // closeItemBindingSource
            // 
            this.closeItemBindingSource.DataSource = typeof(NTarget.Model.CloseItem);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnChange,
            this.btnDel,
            this.btnReturn,
            this.btnReport});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnChange
            // 
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(194, 20);
            this.btnChange.Text = "Изменить выполненную услугу";
            // 
            // btnDel
            // 
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(102, 20);
            this.btnDel.Text = "Удалить услугу";
            // 
            // btnReturn
            // 
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(113, 20);
            this.btnReturn.Text = "Вернуть в работу";
            // 
            // btnReport
            // 
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(51, 20);
            this.btnReport.Text = "Отчет";
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(190, 47);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(200, 20);
            this.dtp1.TabIndex = 10;
            // 
            // dtp2
            // 
            this.dtp2.Location = new System.Drawing.Point(190, 77);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(200, 20);
            this.dtp2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Выручка агентства за период:";
            // 
            // tbAllSum
            // 
            this.tbAllSum.Location = new System.Drawing.Point(190, 107);
            this.tbAllSum.Name = "tbAllSum";
            this.tbAllSum.Size = new System.Drawing.Size(200, 20);
            this.tbAllSum.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Начало работы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Окончание работы";
            // 
            // idCloseItemDataGridViewTextBoxColumn
            // 
            this.idCloseItemDataGridViewTextBoxColumn.DataPropertyName = "IdCloseItem";
            this.idCloseItemDataGridViewTextBoxColumn.HeaderText = "IdCloseItem";
            this.idCloseItemDataGridViewTextBoxColumn.Name = "idCloseItemDataGridViewTextBoxColumn";
            this.idCloseItemDataGridViewTextBoxColumn.Visible = false;
            // 
            // closeDateDataGridViewTextBoxColumn
            // 
            this.closeDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.closeDateDataGridViewTextBoxColumn.DataPropertyName = "CloseDate";
            this.closeDateDataGridViewTextBoxColumn.HeaderText = "Дата выполнения задачи по услуге";
            this.closeDateDataGridViewTextBoxColumn.Name = "closeDateDataGridViewTextBoxColumn";
            this.closeDateDataGridViewTextBoxColumn.Width = 147;
            // 
            // performanceSumDataGridViewTextBoxColumn
            // 
            this.performanceSumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.performanceSumDataGridViewTextBoxColumn.DataPropertyName = "PerformanceSum";
            this.performanceSumDataGridViewTextBoxColumn.HeaderText = "Выручка";
            this.performanceSumDataGridViewTextBoxColumn.Name = "performanceSumDataGridViewTextBoxColumn";
            this.performanceSumDataGridViewTextBoxColumn.Width = 75;
            // 
            // idWorkerDataGridViewTextBoxColumn
            // 
            this.idWorkerDataGridViewTextBoxColumn.DataPropertyName = "IdWorker";
            this.idWorkerDataGridViewTextBoxColumn.HeaderText = "IdWorker";
            this.idWorkerDataGridViewTextBoxColumn.Name = "idWorkerDataGridViewTextBoxColumn";
            this.idWorkerDataGridViewTextBoxColumn.Visible = false;
            // 
            // idServiceItemDataGridViewTextBoxColumn
            // 
            this.idServiceItemDataGridViewTextBoxColumn.DataPropertyName = "IdServiceItem";
            this.idServiceItemDataGridViewTextBoxColumn.HeaderText = "IdServiceItem";
            this.idServiceItemDataGridViewTextBoxColumn.Name = "idServiceItemDataGridViewTextBoxColumn";
            this.idServiceItemDataGridViewTextBoxColumn.Visible = false;
            // 
            // serviceItemDataGridViewTextBoxColumn
            // 
            this.serviceItemDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.serviceItemDataGridViewTextBoxColumn.DataPropertyName = "ServiceItem";
            this.serviceItemDataGridViewTextBoxColumn.HeaderText = "Наименование услуги";
            this.serviceItemDataGridViewTextBoxColumn.Name = "serviceItemDataGridViewTextBoxColumn";
            this.serviceItemDataGridViewTextBoxColumn.Width = 132;
            // 
            // workerDataGridViewTextBoxColumn
            // 
            this.workerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.workerDataGridViewTextBoxColumn.DataPropertyName = "Worker";
            this.workerDataGridViewTextBoxColumn.HeaderText = "Исполнитель";
            this.workerDataGridViewTextBoxColumn.Name = "workerDataGridViewTextBoxColumn";
            this.workerDataGridViewTextBoxColumn.Width = 99;
            // 
            // ReestrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAllSum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp2);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvCloseItem);
            this.Name = "ReestrForm";
            this.Text = "Выполненные услуги и выручка агентства";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCloseItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeItemBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCloseItem;
        private System.Windows.Forms.BindingSource closeItemBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnChange;
        private System.Windows.Forms.ToolStripMenuItem btnDel;
        private System.Windows.Forms.ToolStripMenuItem btnReturn;
        private System.Windows.Forms.ToolStripMenuItem btnReport;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAllSum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCloseItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn closeDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn performanceSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idWorkerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idServiceItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerDataGridViewTextBoxColumn;
    }
}