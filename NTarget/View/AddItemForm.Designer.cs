namespace NTarget.View
{
    partial class AddItemForm
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
            this.cbSpecification = new System.Windows.Forms.ComboBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtFinish = new System.Windows.Forms.DateTimePicker();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nCoef = new System.Windows.Forms.NumericUpDown();
            this.tbPrice = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nCoef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSpecification
            // 
            this.cbSpecification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpecification.FormattingEnabled = true;
            this.cbSpecification.Location = new System.Drawing.Point(53, 304);
            this.cbSpecification.Name = "cbSpecification";
            this.cbSpecification.Size = new System.Drawing.Size(200, 21);
            this.cbSpecification.TabIndex = 0;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(53, 31);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(200, 20);
            this.tbName.TabIndex = 1;
            // 
            // dtStart
            // 
            this.dtStart.Enabled = false;
            this.dtStart.Location = new System.Drawing.Point(53, 85);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(200, 20);
            this.dtStart.TabIndex = 2;
            // 
            // dtFinish
            // 
            this.dtFinish.Location = new System.Drawing.Point(53, 140);
            this.dtFinish.MinDate = new System.DateTime(2020, 6, 13, 0, 44, 8, 0);
            this.dtFinish.Name = "dtFinish";
            this.dtFinish.Size = new System.Drawing.Size(200, 20);
            this.dtFinish.TabIndex = 3;
            this.dtFinish.Value = new System.DateTime(2020, 6, 13, 0, 44, 8, 0);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(53, 349);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(200, 42);
            this.btnAddItem.TabIndex = 7;
            this.btnAddItem.Text = "Добавить новую услугу";
            this.btnAddItem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Введите название услуги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Дата открытия услуги";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Введите дедлайн";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Введите количество единиц услуги";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Введите минимальную цену за единицу";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Выберите спецификацию";
            // 
            // nCoef
            // 
            this.nCoef.DecimalPlaces = 1;
            this.nCoef.Location = new System.Drawing.Point(53, 195);
            this.nCoef.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nCoef.Name = "nCoef";
            this.nCoef.Size = new System.Drawing.Size(200, 20);
            this.nCoef.TabIndex = 15;
            this.nCoef.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbPrice
            // 
            this.tbPrice.DecimalPlaces = 1;
            this.tbPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.tbPrice.Location = new System.Drawing.Point(53, 247);
            this.tbPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(200, 20);
            this.tbPrice.TabIndex = 16;
            this.tbPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 402);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.nCoef);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.dtFinish);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.cbSpecification);
            this.Name = "AddItemForm";
            this.Text = "Добавление новой услуги";
            ((System.ComponentModel.ISupportInitialize)(this.nCoef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSpecification;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtFinish;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nCoef;
        private System.Windows.Forms.NumericUpDown tbPrice;
    }
}