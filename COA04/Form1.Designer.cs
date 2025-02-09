namespace COA04
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.cbbOrderPeople = new System.Windows.Forms.ComboBox();
            this.grpCash = new System.Windows.Forms.GroupBox();
            this.radIsPayByCashN = new System.Windows.Forms.RadioButton();
            this.radIsPayByCashY = new System.Windows.Forms.RadioButton();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lstRecord = new System.Windows.Forms.ListBox();
            this.grpCash.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "人數";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "付現";
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Location = new System.Drawing.Point(51, 19);
            this.dtpOrderDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(135, 22);
            this.dtpOrderDate.TabIndex = 3;
            // 
            // cbbOrderPeople
            // 
            this.cbbOrderPeople.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbOrderPeople.FormattingEnabled = true;
            this.cbbOrderPeople.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbbOrderPeople.Location = new System.Drawing.Point(51, 60);
            this.cbbOrderPeople.Margin = new System.Windows.Forms.Padding(2);
            this.cbbOrderPeople.Name = "cbbOrderPeople";
            this.cbbOrderPeople.Size = new System.Drawing.Size(135, 20);
            this.cbbOrderPeople.TabIndex = 4;
            // 
            // grpCash
            // 
            this.grpCash.Controls.Add(this.radIsPayByCashN);
            this.grpCash.Controls.Add(this.radIsPayByCashY);
            this.grpCash.Location = new System.Drawing.Point(51, 81);
            this.grpCash.Margin = new System.Windows.Forms.Padding(2);
            this.grpCash.Name = "grpCash";
            this.grpCash.Padding = new System.Windows.Forms.Padding(2);
            this.grpCash.Size = new System.Drawing.Size(133, 40);
            this.grpCash.TabIndex = 5;
            this.grpCash.TabStop = false;
            // 
            // radIsPayByCashN
            // 
            this.radIsPayByCashN.AutoSize = true;
            this.radIsPayByCashN.Location = new System.Drawing.Point(73, 17);
            this.radIsPayByCashN.Margin = new System.Windows.Forms.Padding(2);
            this.radIsPayByCashN.Name = "radIsPayByCashN";
            this.radIsPayByCashN.Size = new System.Drawing.Size(35, 16);
            this.radIsPayByCashN.TabIndex = 1;
            this.radIsPayByCashN.Text = "否";
            this.radIsPayByCashN.UseVisualStyleBackColor = true;
            // 
            // radIsPayByCashY
            // 
            this.radIsPayByCashY.AutoSize = true;
            this.radIsPayByCashY.Checked = true;
            this.radIsPayByCashY.Location = new System.Drawing.Point(21, 17);
            this.radIsPayByCashY.Margin = new System.Windows.Forms.Padding(2);
            this.radIsPayByCashY.Name = "radIsPayByCashY";
            this.radIsPayByCashY.Size = new System.Drawing.Size(35, 16);
            this.radIsPayByCashY.TabIndex = 0;
            this.radIsPayByCashY.TabStop = true;
            this.radIsPayByCashY.Text = "是";
            this.radIsPayByCashY.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(228, 19);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(64, 27);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "訂房";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(228, 92);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 27);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lstRecord
            // 
            this.lstRecord.FormattingEnabled = true;
            this.lstRecord.ItemHeight = 12;
            this.lstRecord.Location = new System.Drawing.Point(19, 132);
            this.lstRecord.Margin = new System.Windows.Forms.Padding(2);
            this.lstRecord.Name = "lstRecord";
            this.lstRecord.Size = new System.Drawing.Size(494, 148);
            this.lstRecord.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 300);
            this.Controls.Add(this.lstRecord);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.grpCash);
            this.Controls.Add(this.cbbOrderPeople);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "訂房系統";
            this.grpCash.ResumeLayout(false);
            this.grpCash.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.ComboBox cbbOrderPeople;
        private System.Windows.Forms.GroupBox grpCash;
        private System.Windows.Forms.RadioButton radIsPayByCashN;
        private System.Windows.Forms.RadioButton radIsPayByCashY;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox lstRecord;
    }
}

