namespace $safeprojectname$
{
    partial class paydivm
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
            this.adddiv = new System.Windows.Forms.Button();
            this.listdiv = new System.Windows.Forms.ListView();
            this.num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.divbill = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.divpay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.divst = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.divend = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mpay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_payexpen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.divname = new System.Windows.Forms.ComboBox();
            this.txt_bill = new System.Windows.Forms.TextBox();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.emnames = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datestart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateend = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_memname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_memid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_allbuy = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_allpay = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_allre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // adddiv
            // 
            this.adddiv.Location = new System.Drawing.Point(805, 201);
            this.adddiv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adddiv.Name = "adddiv";
            this.adddiv.Size = new System.Drawing.Size(149, 35);
            this.adddiv.TabIndex = 78;
            this.adddiv.Text = "Add";
            this.adddiv.UseVisualStyleBackColor = true;
            this.adddiv.Click += new System.EventHandler(this.btn_adddiv);
            // 
            // listdiv
            // 
            this.listdiv.BackColor = System.Drawing.SystemColors.HighlightText;
            this.listdiv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.num,
            this.mname,
            this.divbill,
            this.divpay,
            this.divst,
            this.divend,
            this.mpay});
            this.listdiv.GridLines = true;
            this.listdiv.HideSelection = false;
            this.listdiv.Location = new System.Drawing.Point(34, 260);
            this.listdiv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listdiv.Name = "listdiv";
            this.listdiv.Size = new System.Drawing.Size(946, 211);
            this.listdiv.TabIndex = 77;
            this.listdiv.UseCompatibleStateImageBehavior = false;
            this.listdiv.View = System.Windows.Forms.View.Details;
            this.listdiv.DoubleClick += new System.EventHandler(this.listpaydivm_doubleclick);
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
            // divbill
            // 
            this.divbill.Text = "Total Buy";
            this.divbill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.divbill.Width = 179;
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
            this.divend.Width = 139;
            // 
            // mpay
            // 
            this.mpay.Text = "% Dividend";
            this.mpay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mpay.Width = 116;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(852, 510);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 37);
            this.button1.TabIndex = 76;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.save_click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(716, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 75;
            this.label7.Text = "Thai baht";
            // 
            // txt_payexpen
            // 
            this.txt_payexpen.Location = new System.Drawing.Point(481, 215);
            this.txt_payexpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_payexpen.Name = "txt_payexpen";
            this.txt_payexpen.Size = new System.Drawing.Size(218, 22);
            this.txt_payexpen.TabIndex = 74;
            this.txt_payexpen.TextChanged += new System.EventHandler(this.txt_payexpen_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 73;
            this.label5.Text = "Receive";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 70;
            this.label3.Text = "Product:";
            // 
            // divname
            // 
            this.divname.FormattingEnabled = true;
            this.divname.Items.AddRange(new object[] {
            "Pay"});
            this.divname.Location = new System.Drawing.Point(110, 98);
            this.divname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.divname.Name = "divname";
            this.divname.Size = new System.Drawing.Size(178, 24);
            this.divname.TabIndex = 69;
            this.divname.SelectedIndexChanged += new System.EventHandler(this.expenname_SelectedIndexChanged);
            // 
            // txt_bill
            // 
            this.txt_bill.Location = new System.Drawing.Point(680, 52);
            this.txt_bill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_bill.Name = "txt_bill";
            this.txt_bill.Size = new System.Drawing.Size(162, 22);
            this.txt_bill.TabIndex = 68;
            this.txt_bill.TextChanged += new System.EventHandler(this.txt_bill_TextChanged);
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(110, 54);
            this.txt_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(160, 22);
            this.txt_date.TabIndex = 67;
            // 
            // emnames
            // 
            this.emnames.FormattingEnabled = true;
            this.emnames.Location = new System.Drawing.Point(391, 52);
            this.emnames.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emnames.Name = "emnames";
            this.emnames.Size = new System.Drawing.Size(164, 24);
            this.emnames.TabIndex = 66;
            this.emnames.SelectedIndexChanged += new System.EventHandler(this.emnames_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 65;
            this.label6.Text = "Supervisor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 64;
            this.label2.Text = "Pay Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(580, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 63;
            this.label1.Text = "Receipt :";
            // 
            // datestart
            // 
            this.datestart.CustomFormat = "yyyy-MM-dd";
            this.datestart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datestart.Location = new System.Drawing.Point(110, 156);
            this.datestart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datestart.Name = "datestart";
            this.datestart.Size = new System.Drawing.Size(178, 22);
            this.datestart.TabIndex = 79;
            this.datestart.ValueChanged += new System.EventHandler(this.dateTimeStart_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 80;
            this.label4.Text = "Calculate From:";
            // 
            // dateend
            // 
            this.dateend.CustomFormat = "yyyy-MM-dd";
            this.dateend.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateend.Location = new System.Drawing.Point(391, 155);
            this.dateend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateend.Name = "dateend";
            this.dateend.Size = new System.Drawing.Size(178, 22);
            this.dateend.TabIndex = 81;
            this.dateend.ValueChanged += new System.EventHandler(this.dateTimeEnd_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(339, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 16);
            this.label8.TabIndex = 82;
            this.label8.Text = "Until:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(580, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 16);
            this.label12.TabIndex = 86;
            this.label12.Text = "Fullname:";
            // 
            // txt_memname
            // 
            this.txt_memname.Location = new System.Drawing.Point(680, 102);
            this.txt_memname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_memname.Name = "txt_memname";
            this.txt_memname.Size = new System.Drawing.Size(275, 22);
            this.txt_memname.TabIndex = 85;
            this.txt_memname.TextChanged += new System.EventHandler(this.txt_memname_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(299, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 16);
            this.label11.TabIndex = 84;
            this.label11.Text = "Member ID:";
            // 
            // txt_memid
            // 
            this.txt_memid.Location = new System.Drawing.Point(391, 102);
            this.txt_memid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_memid.Name = "txt_memid";
            this.txt_memid.Size = new System.Drawing.Size(132, 22);
            this.txt_memid.TabIndex = 83;
            this.txt_memid.TextChanged += new System.EventHandler(this.txt_memid_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(299, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 89;
            this.label9.Text = "Thai baht";
            // 
            // txt_allbuy
            // 
            this.txt_allbuy.Location = new System.Drawing.Point(70, 214);
            this.txt_allbuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_allbuy.Name = "txt_allbuy";
            this.txt_allbuy.Size = new System.Drawing.Size(218, 22);
            this.txt_allbuy.TabIndex = 88;
            this.txt_allbuy.TextChanged += new System.EventHandler(this.txtallbuy_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 16);
            this.label10.TabIndex = 87;
            this.label10.Text = "Buy:";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(598, 146);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(105, 31);
            this.btn_search.TabIndex = 90;
            this.btn_search.Text = "Calculate";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_searchclick);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.LightCoral;
            this.btn_back.Location = new System.Drawing.Point(860, 10);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(120, 34);
            this.btn_back.TabIndex = 100;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(760, 486);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 16);
            this.label13.TabIndex = 106;
            this.label13.Text = "Thai baht";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(478, 486);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 16);
            this.label14.TabIndex = 105;
            this.label14.Text = "Receive Amount:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(759, 530);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 16);
            this.label15.TabIndex = 104;
            this.label15.Text = "Thai Baht";
            // 
            // txt_allpay
            // 
            this.txt_allpay.Location = new System.Drawing.Point(598, 488);
            this.txt_allpay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_allpay.Name = "txt_allpay";
            this.txt_allpay.Size = new System.Drawing.Size(149, 22);
            this.txt_allpay.TabIndex = 103;
            this.txt_allpay.TextChanged += new System.EventHandler(this.txt_allpay_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(459, 536);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(128, 16);
            this.label16.TabIndex = 102;
            this.label16.Text = "Remaining Balance:";
            // 
            // txt_allre
            // 
            this.txt_allre.Location = new System.Drawing.Point(596, 530);
            this.txt_allre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_allre.Name = "txt_allre";
            this.txt_allre.Size = new System.Drawing.Size(152, 22);
            this.txt_allre.TabIndex = 101;
            this.txt_allre.TextChanged += new System.EventHandler(this.txt_allre_TextChanged);
            // 
            // paydivm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 568);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_allpay);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_allre);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_allbuy);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_memname);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_memid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateend);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datestart);
            this.Controls.Add(this.adddiv);
            this.Controls.Add(this.listdiv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_payexpen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.divname);
            this.Controls.Add(this.txt_bill);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.emnames);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "paydivm";
            this.Text = "paydivm";
            this.Load += new System.EventHandler(this.paydivm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adddiv;
        private System.Windows.Forms.ListView listdiv;
        private System.Windows.Forms.ColumnHeader num;
        private System.Windows.Forms.ColumnHeader mname;
        private System.Windows.Forms.ColumnHeader divbill;
        private System.Windows.Forms.ColumnHeader divpay;
        private System.Windows.Forms.ColumnHeader divst;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_payexpen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox divname;
        private System.Windows.Forms.TextBox txt_bill;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.ComboBox emnames;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datestart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateend;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_memname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_memid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_allbuy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ColumnHeader divend;
        private System.Windows.Forms.ColumnHeader mpay;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_allpay;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_allre;
    }
}