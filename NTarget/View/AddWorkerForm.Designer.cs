namespace NTarget.View
{
    partial class AddWorkerForm
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbKval = new System.Windows.Forms.TextBox();
            this.nCoef = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nCoef)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 29);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(243, 20);
            this.tbName.TabIndex = 0;
            // 
            // tbKval
            // 
            this.tbKval.Location = new System.Drawing.Point(12, 85);
            this.tbKval.Name = "tbKval";
            this.tbKval.Size = new System.Drawing.Size(243, 20);
            this.tbKval.TabIndex = 1;
            // 
            // nCoef
            // 
            this.nCoef.DecimalPlaces = 1;
            this.nCoef.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nCoef.Location = new System.Drawing.Point(12, 142);
            this.nCoef.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nCoef.Name = "nCoef";
            this.nCoef.Size = new System.Drawing.Size(243, 20);
            this.nCoef.TabIndex = 2;
            this.nCoef.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя нового исполнителя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Квалификация нового исполнителя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Коэффициент на повышение оплаты услуг";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 192);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(243, 50);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Добавить нового исполнителя";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // AddWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 265);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nCoef);
            this.Controls.Add(this.tbKval);
            this.Controls.Add(this.tbName);
            this.Name = "AddWorkerForm";
            this.Text = "Новый исполнитель";
            ((System.ComponentModel.ISupportInitialize)(this.nCoef)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbKval;
        private System.Windows.Forms.NumericUpDown nCoef;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
    }
}