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
            this.cbbPeople = new System.Windows.Forms.ComboBox();
            this.grpCash = new System.Windows.Forms.GroupBox();
            this.radIsCashY = new System.Windows.Forms.RadioButton();
            this.radIsCashN = new System.Windows.Forms.RadioButton();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.grpCash.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "人數";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "付現";
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Location = new System.Drawing.Point(76, 29);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(200, 29);
            this.dtpOrderDate.TabIndex = 3;
            // 
            // cbbPeople
            // 
            this.cbbPeople.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPeople.FormattingEnabled = true;
            this.cbbPeople.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbbPeople.Location = new System.Drawing.Point(76, 90);
            this.cbbPeople.Name = "cbbPeople";
            this.cbbPeople.Size = new System.Drawing.Size(200, 26);
            this.cbbPeople.TabIndex = 4;
            // 
            // grpCash
            // 
            this.grpCash.Controls.Add(this.radIsCashN);
            this.grpCash.Controls.Add(this.radIsCashY);
            this.grpCash.Location = new System.Drawing.Point(76, 122);
            this.grpCash.Name = "grpCash";
            this.grpCash.Size = new System.Drawing.Size(200, 60);
            this.grpCash.TabIndex = 5;
            this.grpCash.TabStop = false;
            // 
            // radIsCashY
            // 
            this.radIsCashY.AutoSize = true;
            this.radIsCashY.Checked = true;
            this.radIsCashY.Location = new System.Drawing.Point(32, 25);
            this.radIsCashY.Name = "radIsCashY";
            this.radIsCashY.Size = new System.Drawing.Size(51, 22);
            this.radIsCashY.TabIndex = 0;
            this.radIsCashY.TabStop = true;
            this.radIsCashY.Text = "是";
            this.radIsCashY.UseVisualStyleBackColor = true;
            // 
            // radIsCashN
            // 
            this.radIsCashN.AutoSize = true;
            this.radIsCashN.Location = new System.Drawing.Point(109, 25);
            this.radIsCashN.Name = "radIsCashN";
            this.radIsCashN.Size = new System.Drawing.Size(51, 22);
            this.radIsCashN.TabIndex = 1;
            this.radIsCashN.Text = "否";
            this.radIsCashN.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(342, 29);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(96, 41);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "訂房";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(342, 138);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 41);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.ItemHeight = 18;
            this.lstResult.Location = new System.Drawing.Point(29, 198);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(739, 220);
            this.lstResult.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.grpCash);
            this.Controls.Add(this.cbbPeople);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.ComboBox cbbPeople;
        private System.Windows.Forms.GroupBox grpCash;
        private System.Windows.Forms.RadioButton radIsCashN;
        private System.Windows.Forms.RadioButton radIsCashY;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox lstResult;
    }
}

