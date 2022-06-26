namespace $safeprojectname$
{
    partial class synexpen
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
            this.addbill = new System.Windows.Forms.Button();
            this.listexpe = new System.Windows.Forms.ListView();
            this.num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lexname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lexdetail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lexpay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lexcode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.txt_payexpen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_detail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.expenname = new System.Windows.Forms.ComboBox();
            this.txt_bill = new System.Windows.Forms.TextBox();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.emnames = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addbill
            // 
            this.addbill.Location = new System.Drawing.Point(463, 166);
            this.addbill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addbill.Name = "addbill";
            this.addbill.Size = new System.Drawing.Size(149, 35);
            this.addbill.TabIndex = 62;
            this.addbill.Text = "Add";
            this.addbill.UseVisualStyleBackColor = true;
            this.addbill.Click += new System.EventHandler(this.addbill_Click);
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
            this.listexpe.Location = new System.Drawing.Point(46, 245);
            this.listexpe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listexpe.Name = "listexpe";
            this.listexpe.Size = new System.Drawing.Size(899, 230);
            this.listexpe.TabIndex = 61;
            this.listexpe.UseCompatibleStateImageBehavior = false;
            this.listexpe.View = System.Windows.Forms.View.Details;
            this.listexpe.DoubleClick += new System.EventHandler(this.listex_doubleclick);
            // 
            // num
            // 
            this.num.Text = "No";
            this.num.Width = 81;
            // 
            // lexname
            // 
            this.lexname.Text = "Expense";
            this.lexname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lexname.Width = 196;
            // 
            // lexdetail
            // 
            this.lexdetail.Text = "Reciept";
            this.lexdetail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lexdetail.Width = 162;
            // 
            // lexpay
            // 
            this.lexpay.Text = "Amount";
            this.lexpay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lexpay.Width = 406;
            // 
            // lexcode
            // 
            this.lexcode.Text = "Reciept No";
            this.lexcode.Width = 47;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(764, 501);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 37);
            this.button1.TabIndex = 60;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnsaved_Click);
            // 
            // txt_payexpen
            // 
            this.txt_payexpen.Location = new System.Drawing.Point(464, 74);
            this.txt_payexpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_payexpen.Name = "txt_payexpen";
            this.txt_payexpen.Size = new System.Drawing.Size(218, 22);
            this.txt_payexpen.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 57;
            this.label5.Text = "Expense Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 56;
            this.label4.Text = "Details:";
            // 
            // txt_detail
            // 
            this.txt_detail.Location = new System.Drawing.Point(124, 126);
            this.txt_detail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_detail.Multiline = true;
            this.txt_detail.Name = "txt_detail";
            this.txt_detail.Size = new System.Drawing.Size(298, 86);
            this.txt_detail.TabIndex = 55;
            this.txt_detail.TextChanged += new System.EventHandler(this.txt_detail_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 54;
            this.label3.Text = "Expense Type:";
            // 
            // expenname
            // 
            this.expenname.FormattingEnabled = true;
            this.expenname.Items.AddRange(new object[] {
            "Salary",
            "Others"});
            this.expenname.Location = new System.Drawing.Point(124, 71);
            this.expenname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.expenname.Name = "expenname";
            this.expenname.Size = new System.Drawing.Size(178, 24);
            this.expenname.TabIndex = 53;
            this.expenname.SelectedIndexChanged += new System.EventHandler(this.expenname_SelectedIndexChanged);
            // 
            // txt_bill
            // 
            this.txt_bill.Location = new System.Drawing.Point(688, 19);
            this.txt_bill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_bill.Name = "txt_bill";
            this.txt_bill.Size = new System.Drawing.Size(162, 22);
            this.txt_bill.TabIndex = 52;
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(124, 16);
            this.txt_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(160, 22);
            this.txt_date.TabIndex = 51;
           
            // 
            // emnames
            // 
            this.emnames.FormattingEnabled = true;
            this.emnames.Location = new System.Drawing.Point(415, 16);
            this.emnames.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emnames.Name = "emnames";
            this.emnames.Size = new System.Drawing.Size(164, 24);
            this.emnames.TabIndex = 50;
            this.emnames.SelectedIndexChanged += new System.EventHandler(this.emnames_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 49;
            this.label6.Text = "Supervisor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 48;
            this.label2.Text = "Pay Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(604, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "Receipt No:";
            // 
            // synexpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 554);
            this.Controls.Add(this.addbill);
            this.Controls.Add(this.listexpe);
            this.Controls.Add(this.button1);
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
            this.Name = "synexpen";
            this.Text = "synexpen";
            this.Load += new System.EventHandler(this.synexpen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addbill;
        private System.Windows.Forms.ListView listexpe;
        private System.Windows.Forms.ColumnHeader num;
        private System.Windows.Forms.ColumnHeader lexname;
        private System.Windows.Forms.ColumnHeader lexdetail;
        private System.Windows.Forms.ColumnHeader lexpay;
        private System.Windows.Forms.ColumnHeader lexcode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_payexpen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_detail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox expenname;
        private System.Windows.Forms.TextBox txt_bill;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.ComboBox emnames;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}