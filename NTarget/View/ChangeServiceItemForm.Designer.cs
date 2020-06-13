namespace NTarget.View
{
    partial class ChangeServiceItemForm
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
            this.tbPrice = new System.Windows.Forms.NumericUpDown();
            this.nCoef = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditItem = new System.Windows.Forms.Button();
            this.dtFinish = new System.Windows.Forms.DateTimePicker();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbSpecification = new System.Windows.Forms.ComboBox();
            this.cbItem = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCoef)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPrice
            // 
            this.tbPrice.DecimalPlaces = 1;
            this.tbPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.tbPrice.Location = new System.Drawing.Point(54, 294);
            this.tbPrice.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.tbPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(200, 20);
            this.tbPrice.TabIndex = 29;
            this.tbPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nCoef
            // 
            this.nCoef.DecimalPlaces = 1;
            this.nCoef.Location = new System.Drawing.Point(54, 242);
            this.nCoef.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nCoef.Name = "nCoef";
            this.nCoef.Size = new System.Drawing.Size(200, 20);
            this.nCoef.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Выберите спецификацию";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Введите минимальную цену за единицу";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Введите количество единиц услуги";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Введите дедлайн";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Дата открытия услуги";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Введите название услуги";
            // 
            // btnEditItem
            // 
            this.btnEditItem.Location = new System.Drawing.Point(54, 396);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(200, 42);
            this.btnEditItem.TabIndex = 21;
            this.btnEditItem.Text = "Редактировать услугу";
            this.btnEditItem.UseVisualStyleBackColor = true;
            // 
            // dtFinish
            // 
            this.dtFinish.Location = new System.Drawing.Point(54, 187);
            this.dtFinish.MinDate = new System.DateTime(2020, 6, 13, 0, 44, 8, 0);
            this.dtFinish.Name = "dtFinish";
            this.dtFinish.Size = new System.Drawing.Size(200, 20);
            this.dtFinish.TabIndex = 20;
            this.dtFinish.Value = new System.DateTime(2020, 6, 13, 0, 44, 8, 0);
            // 
            // dtStart
            // 
            this.dtStart.Enabled = false;
            this.dtStart.Location = new System.Drawing.Point(54, 132);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(200, 20);
            this.dtStart.TabIndex = 19;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(54, 78);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(200, 20);
            this.tbName.TabIndex = 18;
            // 
            // cbSpecification
            // 
            this.cbSpecification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpecification.FormattingEnabled = true;
            this.cbSpecification.Location = new System.Drawing.Point(54, 351);
            this.cbSpecification.Name = "cbSpecification";
            this.cbSpecification.Size = new System.Drawing.Size(200, 21);
            this.cbSpecification.TabIndex = 17;
            // 
            // cbItem
            // 
            this.cbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbItem.FormattingEnabled = true;
            this.cbItem.Location = new System.Drawing.Point(54, 28);
            this.cbItem.Name = "cbItem";
            this.cbItem.Size = new System.Drawing.Size(200, 21);
            this.cbItem.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Выберите услугу для редактирования";
            // 
            // ChangeServiceItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbItem);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.nCoef);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditItem);
            this.Controls.Add(this.dtFinish);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.cbSpecification);
            this.Name = "ChangeServiceItemForm";
            this.Text = "Редактирование услуги";
            ((System.ComponentModel.ISupportInitialize)(this.tbPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCoef)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown tbPrice;
        private System.Windows.Forms.NumericUpDown nCoef;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditItem;
        private System.Windows.Forms.DateTimePicker dtFinish;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cbSpecification;
        private System.Windows.Forms.ComboBox cbItem;
        private System.Windows.Forms.Label label6;
    }
}