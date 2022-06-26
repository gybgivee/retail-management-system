namespace $safeprojectname$
{
    partial class paydivsyn
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
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_expen = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateend = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.datestart = new System.Windows.Forms.DateTimePicker();
            this.listdiv = new System.Windows.Forms.ListView();
            this.num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.divpay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.divst = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.divend = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mpay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.div = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.txt_profit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.divname = new System.Windows.Forms.ComboBox();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_income = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.emnames = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_bill = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_allpay = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_allre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(674, 136);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(105, 31);
            this.btn_search.TabIndex = 116;
            this.btn_search.Text = "Calculate";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_expen
            // 
            this.txt_expen.Location = new System.Drawing.Point(441, 217);
            this.txt_expen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_expen.Name = "txt_expen";
            this.txt_expen.Size = new System.Drawing.Size(187, 22);
            this.txt_expen.TabIndex = 114;
            this.txt_expen.TextChanged += new System.EventHandler(this.txt_payexpen_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(354, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 16);
            this.label10.TabIndex = 113;
            this.label10.Text = "Expenses:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(354, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 16);
            this.label8.TabIndex = 108;
            this.label8.Text = "Until:";
            // 
            // dateend
            // 
            this.dateend.CustomFormat = "yyyy-MM-dd";
            this.dateend.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateend.Location = new System.Drawing.Point(424, 136);
            this.dateend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateend.Name = "dateend";
            this.dateend.Size = new System.Drawing.Size(178, 22);
            this.dateend.TabIndex = 107;
            this.dateend.ValueChanged += new System.EventHandler(this.dateend_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 106;
            this.label4.Text = "Calculate From";
            // 
            // datestart
            // 
            this.datestart.CustomFormat = "yyyy-MM-dd";
            this.datestart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datestart.Location = new System.Drawing.Point(159, 136);
            this.datestart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datestart.Name = "datestart";
            this.datestart.Size = new System.Drawing.Size(178, 22);
            this.datestart.TabIndex = 105;
            this.datestart.ValueChanged += new System.EventHandler(this.datestart_ValueChanged);
            // 
            // listdiv
            // 
            this.listdiv.BackColor = System.Drawing.SystemColors.HighlightText;
            this.listdiv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.num,
            this.mname,
            this.divpay,
            this.divst,
            this.divend,
            this.mpay,
            this.div});
            this.listdiv.GridLines = true;
            this.listdiv.HideSelection = false;
            this.listdiv.Location = new System.Drawing.Point(43, 273);
            this.listdiv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listdiv.Name = "listdiv";
            this.listdiv.Size = new System.Drawing.Size(986, 194);
            this.listdiv.TabIndex = 103;
            this.listdiv.UseCompatibleStateImageBehavior = false;
            this.listdiv.View = System.Windows.Forms.View.Details;
            this.listdiv.SelectedIndexChanged += new System.EventHandler(this.listdiv_SelectedIndexChanged);
            this.listdiv.DoubleClick += new System.EventHandler(this.listdiv_doubleclick);
            // 
            // num
            // 
            this.num.Text = "No";
            this.num.Width = 76;
            // 
            // mname
            // 
            this.mname.Text = "Fullname";
            this.mname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mname.Width = 258;
            // 
            // divpay
            // 
            this.divpay.Text = "Total Recieve";
            this.divpay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.divpay.Width = 159;
            // 
            // divst
            // 
            this.divst.Text = "From";
            this.divst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.divst.Width = 129;
            // 
            // divend
            // 
            this.divend.Text = "Until";
            this.divend.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.divend.Width = 156;
            // 
            // mpay
            // 
            this.mpay.Text = "% Dividend";
            this.mpay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mpay.Width = 151;
            // 
            // div
            // 
            this.div.Text = "No";
            this.div.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.div.Width = 178;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(914, 519);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 37);
            this.button1.TabIndex = 102;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txt_profit
            // 
            this.txt_profit.Location = new System.Drawing.Point(750, 217);
            this.txt_profit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_profit.Name = "txt_profit";
            this.txt_profit.Size = new System.Drawing.Size(201, 22);
            this.txt_profit.TabIndex = 100;
            this.txt_profit.TextChanged += new System.EventHandler(this.txt_payexpen_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(671, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 99;
            this.label5.Text = "Profit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 98;
            this.label3.Text = "Expense:";
            // 
            // divname
            // 
            this.divname.FormattingEnabled = true;
            this.divname.Items.AddRange(new object[] {
            "Pay"});
            this.divname.Location = new System.Drawing.Point(115, 70);
            this.divname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.divname.Name = "divname";
            this.divname.Size = new System.Drawing.Size(178, 24);
            this.divname.TabIndex = 97;
            this.divname.SelectedIndexChanged += new System.EventHandler(this.divname_SelectedIndexChanged);
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(115, 19);
            this.txt_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(160, 22);
            this.txt_date.TabIndex = 95;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 92;
            this.label2.Text = "Pay Date :";
            // 
            // txt_income
            // 
            this.txt_income.Location = new System.Drawing.Point(75, 220);
            this.txt_income.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_income.Name = "txt_income";
            this.txt_income.Size = new System.Drawing.Size(218, 22);
            this.txt_income.TabIndex = 117;
            this.txt_income.TextChanged += new System.EventHandler(this.allrecieve_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 118;
            this.label6.Text = "Income:";
            // 
            // emnames
            // 
            this.emnames.FormattingEnabled = true;
            this.emnames.Location = new System.Drawing.Point(424, 66);
            this.emnames.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emnames.Name = "emnames";
            this.emnames.Size = new System.Drawing.Size(204, 24);
            this.emnames.TabIndex = 120;
            this.emnames.SelectedIndexChanged += new System.EventHandler(this.emnames_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 121;
            this.label1.Text = "Supervisor :";
            // 
            // txt_bill
            // 
            this.txt_bill.Location = new System.Drawing.Point(424, 22);
            this.txt_bill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_bill.Name = "txt_bill";
            this.txt_bill.Size = new System.Drawing.Size(162, 22);
            this.txt_bill.TabIndex = 123;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(326, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 16);
            this.label12.TabIndex = 122;
            this.label12.Text = "No:";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.LightCoral;
            this.btn_back.Location = new System.Drawing.Point(914, 41);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(132, 34);
            this.btn_back.TabIndex = 124;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(813, 490);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 16);
            this.label13.TabIndex = 130;
            this.label13.Text = "Thai Baht";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(532, 490);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 16);
            this.label14.TabIndex = 129;
            this.label14.Text = "Pay:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(821, 534);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 16);
            this.label15.TabIndex = 128;
            this.label15.Text = "Thai Baht";
            // 
            // txt_allpay
            // 
            this.txt_allpay.Location = new System.Drawing.Point(652, 493);
            this.txt_allpay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_allpay.Name = "txt_allpay";
            this.txt_allpay.Size = new System.Drawing.Size(149, 22);
            this.txt_allpay.TabIndex = 127;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(500, 534);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(128, 16);
            this.label16.TabIndex = 126;
            this.label16.Text = "Remaining Balance:";
            // 
            // txt_allre
            // 
            this.txt_allre.Location = new System.Drawing.Point(649, 534);
            this.txt_allre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_allre.Name = "txt_allre";
            this.txt_allre.Size = new System.Drawing.Size(152, 22);
            this.txt_allre.TabIndex = 125;
            this.txt_allre.TextChanged += new System.EventHandler(this.txt_allre_TextChanged);
            // 
            // paydivsyn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 574);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_allpay);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_allre);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.txt_bill);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emnames);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_income);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_expen);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateend);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datestart);
            this.Controls.Add(this.listdiv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_profit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.divname);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "paydivsyn";
            this.Text = "paydivsyn";
            this.Load += new System.EventHandler(this.paydivsyn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_expen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datestart;
        private System.Windows.Forms.ListView listdiv;
        private System.Windows.Forms.ColumnHeader num;
        private System.Windows.Forms.ColumnHeader mname;
        private System.Windows.Forms.ColumnHeader divpay;
        private System.Windows.Forms.ColumnHeader divst;
        private System.Windows.Forms.ColumnHeader divend;
        private System.Windows.Forms.ColumnHeader mpay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_profit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox divname;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_income;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader div;
        private System.Windows.Forms.ComboBox emnames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_bill;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_allpay;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_allre;
    }
}