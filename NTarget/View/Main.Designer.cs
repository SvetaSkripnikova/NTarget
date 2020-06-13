namespace NTarget.View
{
    partial class Main
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
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.cbWorkers = new System.Windows.Forms.ComboBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.работаСУслугамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddSI = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChangeSI = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelSI = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddWorker = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCloseItems = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReport = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDoItem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idServiceItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameServiceItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startSateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.counDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSpecificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.AutoGenerateColumns = false;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idServiceItemDataGridViewTextBoxColumn,
            this.nameServiceItemDataGridViewTextBoxColumn,
            this.specificationDataGridViewTextBoxColumn,
            this.startSateDataGridViewTextBoxColumn,
            this.finishDateDataGridViewTextBoxColumn,
            this.counDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.idSpecificationDataGridViewTextBoxColumn,
            this.closeItemDataGridViewTextBoxColumn});
            this.dgvMain.DataSource = this.serviceItemBindingSource;
            this.dgvMain.Location = new System.Drawing.Point(12, 194);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.Size = new System.Drawing.Size(975, 244);
            this.dgvMain.TabIndex = 0;
            // 
            // cbWorkers
            // 
            this.cbWorkers.FormattingEnabled = true;
            this.cbWorkers.Location = new System.Drawing.Point(12, 74);
            this.cbWorkers.Name = "cbWorkers";
            this.cbWorkers.Size = new System.Drawing.Size(206, 21);
            this.cbWorkers.TabIndex = 1;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(12, 122);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(206, 20);
            this.tbPrice.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работаСУслугамиToolStripMenuItem,
            this.btnAddWorker,
            this.btnCloseItems});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(999, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // работаСУслугамиToolStripMenuItem
            // 
            this.работаСУслугамиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddSI,
            this.btnChangeSI,
            this.btnDelSI,
            this.btnReport});
            this.работаСУслугамиToolStripMenuItem.Name = "работаСУслугамиToolStripMenuItem";
            this.работаСУслугамиToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.работаСУслугамиToolStripMenuItem.Text = "Работа с услугами";
            // 
            // btnAddSI
            // 
            this.btnAddSI.Name = "btnAddSI";
            this.btnAddSI.Size = new System.Drawing.Size(167, 22);
            this.btnAddSI.Text = "Добавить услугу";
            // 
            // btnChangeSI
            // 
            this.btnChangeSI.Name = "btnChangeSI";
            this.btnChangeSI.Size = new System.Drawing.Size(167, 22);
            this.btnChangeSI.Text = "Изменить услугу";
            // 
            // btnDelSI
            // 
            this.btnDelSI.Name = "btnDelSI";
            this.btnDelSI.Size = new System.Drawing.Size(167, 22);
            this.btnDelSI.Text = "Удалить услугу";
            // 
            // btnAddWorker
            // 
            this.btnAddWorker.Name = "btnAddWorker";
            this.btnAddWorker.Size = new System.Drawing.Size(146, 20);
            this.btnAddWorker.Text = "Добавить исполнителя";
            // 
            // btnCloseItems
            // 
            this.btnCloseItems.Name = "btnCloseItems";
            this.btnCloseItems.Size = new System.Drawing.Size(89, 20);
            this.btnCloseItems.Text = "Реестр услуг";
            // 
            // btnReport
            // 
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(167, 22);
            this.btnReport.Text = "Отчет";
            // 
            // btnDoItem
            // 
            this.btnDoItem.Location = new System.Drawing.Point(12, 155);
            this.btnDoItem.Name = "btnDoItem";
            this.btnDoItem.Size = new System.Drawing.Size(206, 23);
            this.btnDoItem.TabIndex = 4;
            this.btnDoItem.Text = "Выполнить услугу";
            this.btnDoItem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите исполнителя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Стоимость единицы услуги";
            // 
            // idServiceItemDataGridViewTextBoxColumn
            // 
            this.idServiceItemDataGridViewTextBoxColumn.DataPropertyName = "IdServiceItem";
            this.idServiceItemDataGridViewTextBoxColumn.HeaderText = "IdServiceItem";
            this.idServiceItemDataGridViewTextBoxColumn.Name = "idServiceItemDataGridViewTextBoxColumn";
            this.idServiceItemDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameServiceItemDataGridViewTextBoxColumn
            // 
            this.nameServiceItemDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameServiceItemDataGridViewTextBoxColumn.DataPropertyName = "NameServiceItem";
            this.nameServiceItemDataGridViewTextBoxColumn.HeaderText = "Наименование услуги";
            this.nameServiceItemDataGridViewTextBoxColumn.Name = "nameServiceItemDataGridViewTextBoxColumn";
            this.nameServiceItemDataGridViewTextBoxColumn.Width = 132;
            // 
            // specificationDataGridViewTextBoxColumn
            // 
            this.specificationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.specificationDataGridViewTextBoxColumn.DataPropertyName = "Specification";
            this.specificationDataGridViewTextBoxColumn.HeaderText = "Спецификация";
            this.specificationDataGridViewTextBoxColumn.Name = "specificationDataGridViewTextBoxColumn";
            this.specificationDataGridViewTextBoxColumn.Width = 107;
            // 
            // startSateDataGridViewTextBoxColumn
            // 
            this.startSateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.startSateDataGridViewTextBoxColumn.DataPropertyName = "StartSate";
            this.startSateDataGridViewTextBoxColumn.HeaderText = "Дата заказа услуги";
            this.startSateDataGridViewTextBoxColumn.Name = "startSateDataGridViewTextBoxColumn";
            this.startSateDataGridViewTextBoxColumn.Width = 122;
            // 
            // finishDateDataGridViewTextBoxColumn
            // 
            this.finishDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.finishDateDataGridViewTextBoxColumn.DataPropertyName = "FinishDate";
            this.finishDateDataGridViewTextBoxColumn.HeaderText = "Дедлайн";
            this.finishDateDataGridViewTextBoxColumn.Name = "finishDateDataGridViewTextBoxColumn";
            this.finishDateDataGridViewTextBoxColumn.Width = 77;
            // 
            // counDataGridViewTextBoxColumn
            // 
            this.counDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.counDataGridViewTextBoxColumn.DataPropertyName = "Coun";
            this.counDataGridViewTextBoxColumn.HeaderText = "Количество единиц услуги";
            this.counDataGridViewTextBoxColumn.Name = "counDataGridViewTextBoxColumn";
            this.counDataGridViewTextBoxColumn.Width = 122;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена за единицу";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 107;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Минимальная выручка от выполнения услуги";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.Width = 150;
            // 
            // idSpecificationDataGridViewTextBoxColumn
            // 
            this.idSpecificationDataGridViewTextBoxColumn.DataPropertyName = "IdSpecification";
            this.idSpecificationDataGridViewTextBoxColumn.HeaderText = "IdSpecification";
            this.idSpecificationDataGridViewTextBoxColumn.Name = "idSpecificationDataGridViewTextBoxColumn";
            this.idSpecificationDataGridViewTextBoxColumn.Visible = false;
            // 
            // closeItemDataGridViewTextBoxColumn
            // 
            this.closeItemDataGridViewTextBoxColumn.DataPropertyName = "CloseItem";
            this.closeItemDataGridViewTextBoxColumn.HeaderText = "CloseItem";
            this.closeItemDataGridViewTextBoxColumn.Name = "closeItemDataGridViewTextBoxColumn";
            this.closeItemDataGridViewTextBoxColumn.Visible = false;
            // 
            // serviceItemBindingSource
            // 
            this.serviceItemBindingSource.DataSource = typeof(NTarget.Model.ServiceItem);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDoItem);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.cbWorkers);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Учёт услуг маркетингового агентства";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.ComboBox cbWorkers;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem работаСУслугамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAddSI;
        private System.Windows.Forms.ToolStripMenuItem btnChangeSI;
        private System.Windows.Forms.ToolStripMenuItem btnDelSI;
        private System.Windows.Forms.ToolStripMenuItem btnReport;
        private System.Windows.Forms.ToolStripMenuItem btnAddWorker;
        private System.Windows.Forms.ToolStripMenuItem btnCloseItems;
        private System.Windows.Forms.Button btnDoItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource serviceItemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idServiceItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameServiceItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startSateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finishDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn counDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSpecificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn closeItemDataGridViewTextBoxColumn;
    }
}