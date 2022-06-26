namespace $safeprojectname$
{
    partial class expen
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
            this.txt_bill = new System.Windows.Forms.TextBox();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.emnames = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.expenname = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_detail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_payexpen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listexpe = new System.Windows.Forms.ListView();
            this.num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lexname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lexdetail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lexpay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lexcode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addbill = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_bill
            // 
            this.txt_bill.Location = new System.Drawing.Point(595, 24);
            this.txt_bill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_bill.Name = "txt_bill";
            this.txt_bill.Size = new System.Drawing.Size(162, 22);
            this.txt_bill.TabIndex = 36;
            this.txt_bill.TextChanged += new System.EventHandler(this.txt_bill_TextChanged);
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(110, 24);
            this.txt_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(130, 22);
            this.txt_date.TabIndex = 35;
            this.txt_date.TextChanged += new System.EventHandler(this.txt_date_TextChanged);
            // 
            // emnames
            // 
            this.emnames.FormattingEnabled = true;
            this.emnames.Location = new System.Drawing.Point(346, 24);
            this.emnames.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emnames.Name = "emnames";
            this.emnames.Size = new System.Drawing.Size(164, 24);
            this.emnames.TabIndex = 34;
            this.emnames.SelectedIndexChanged += new System.EventHandler(this.emname_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Employee:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Pay Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(525, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Receipt:";
            // 
            // expenname
            // 
            this.expenname.FormattingEnabled = true;
            this.expenname.Items.AddRange(new object[] {
            "Water Bill",
            "Electricity Bill",
            "Phone Bill",
            "Tax",
            "Maintenance",
            "Store Expenses",
            "Others"});
            this.expenname.Location = new System.Drawing.Point(94, 84);
            this.expenname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.expenname.Name = "expenname";
            this.expenname.Size = new System.Drawing.Size(178, 24);
            this.expenname.TabIndex = 37;
            this.expenname.SelectedIndexChanged += new System.EventHandler(this.expenname_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Expense:";
            // 
            // txt_detail
            // 
            this.txt_detail.Location = new System.Drawing.Point(94, 134);
            this.txt_detail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_detail.Multiline = true;
            this.txt_detail.Name = "txt_detail";
            this.txt_detail.Size = new System.Drawing.Size(298, 86);
            this.txt_detail.TabIndex = 39;
            this.txt_detail.TextChanged += new System.EventHandler(this.txt_detail_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Details:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "Amount";
            // 
            // txt_payexpen
            // 
            this.txt_payexpen.Location = new System.Drawing.Point(346, 86);
            this.txt_payexpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_payexpen.Name = "txt_payexpen";
            this.txt_payexpen.Size = new System.Drawing.Size(218, 22);
            this.txt_payexpen.TabIndex = 42;
            this.txt_payexpen.TextChanged += new System.EventHandler(this.txt_payexpen_TextChanged);
            this.txt_payexpen.Enter += new System.EventHandler(this.txt_payexpenenter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(592, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 43;
            this.label7.Text = "Thai Baht";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(751, 509);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 37);
            this.button1.TabIndex = 44;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_saveexpen);
            // 
            // listexpe
            // 
            this.listexpe.BackColor = System.Drawing.SystemColors.HighlightText;
            this.listexpe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.num,
            this.lexname,
            this.lexdetail,
            this.lexpay,
            this.lexcode});
            this.listexpe.GridLines = true;
            this.listexpe.HideSelection = false;
            this.listexpe.Location = new System.Drawing.Point(57, 254);
            this.listexpe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listexpe.Name = "listexpe";
            this.listexpe.Size = new System.Drawing.Size(878, 230);
            this.listexpe.TabIndex = 45;
            this.listexpe.UseCompatibleStateImageBehavior = false;
            this.listexpe.View = System.Windows.Forms.View.Details;
            this.listexpe.SelectedIndexChanged += new System.EventHandler(this.liststock_SelectedIndexChanged);
            this.listexpe.DoubleClick += new System.EventHandler(this.listexpen_doubleclick);
            // 
            // num
            // 
            this.num.Text = "No";
            this.num.Width = 72;
            // 
            // lexname
            // 
            this.lexname.Text = "Expense";
            this.lexname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lexname.Width = 231;
            // 
            // lexdetail
            // 
            this.lexdetail.Text = "Details";
            this.lexdetail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lexdetail.Width = 299;
            // 
            // lexpay
            // 
            this.lexpay.Text = "Amount";
            this.lexpay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lexpay.Width = 162;
            // 
            // lexcode
            // 
            this.lexcode.Text = "Receipt ID";
            this.lexcode.Width = 124;
            // 
            // addbill
            // 
            this.addbill.Location = new System.Drawing.Point(433, 174);
            this.addbill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addbill.Name = "addbill";
            this.addbill.Size = new System.Drawing.Size(149, 35);
            this.addbill.TabIndex = 46;
            this.addbill.Text = "Add";
            this.addbill.UseVisualStyleBackColor = true;
            this.addbill.Click += new System.EventHandler(this.btn_addex);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.LightCoral;
            this.btn_back.Location = new System.Drawing.Point(821, 15);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(132, 34);
            this.btn_back.TabIndex = 112;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // expen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 566);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.addbill);
            this.Controls.Add(this.listexpe);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_payexpen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_detail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.expenname);
            this.Controls.Add(this.txt_bill);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.emnames);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "expen";
            this.Text = "Expen";
            this.Load += new System.EventHandler(this.Expen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_bill;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.ComboBox emnames;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox expenname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_detail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_payexpen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listexpe;
        private System.Windows.Forms.ColumnHeader num;
        private System.Windows.Forms.ColumnHeader lexname;
        private System.Windows.Forms.ColumnHeader lexdetail;
        private System.Windows.Forms.ColumnHeader lexpay;
        private System.Windows.Forms.Button addbill;
        private System.Windows.Forms.ColumnHeader lexcode;
        private System.Windows.Forms.Button btn_back;
    }
}