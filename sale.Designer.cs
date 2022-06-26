namespace $safeprojectname$
{
    partial class sale
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
            this.txt_date = new System.Windows.Forms.TextBox();
            this.emname = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_bill = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.namepro = new System.Windows.Forms.ComboBox();
            this.tpname = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listsale = new System.Windows.Forms.ListView();
            this.num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.porname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.poramount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.porcost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.porcostall = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ortpname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_allpay = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_allam = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_memid = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_memname = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_addpro = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.txt_salemax = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(71, 16);
            this.txt_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(160, 22);
            this.txt_date.TabIndex = 29;
            // 
            // emname
            // 
            this.emname.FormattingEnabled = true;
            this.emname.Location = new System.Drawing.Point(344, 19);
            this.emname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emname.Name = "emname";
            this.emname.Size = new System.Drawing.Size(164, 24);
            this.emname.TabIndex = 28;
            this.emname.SelectedIndexChanged += new System.EventHandler(this.emname_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Employee:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Receipt :";
            // 
            // txt_bill
            // 
            this.txt_bill.Location = new System.Drawing.Point(614, 19);
            this.txt_bill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_bill.Name = "txt_bill";
            this.txt_bill.Size = new System.Drawing.Size(162, 22);
            this.txt_bill.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Product:";
            // 
            // namepro
            // 
            this.namepro.FormattingEnabled = true;
            this.namepro.Location = new System.Drawing.Point(527, 110);
            this.namepro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.namepro.Name = "namepro";
            this.namepro.Size = new System.Drawing.Size(171, 24);
            this.namepro.TabIndex = 33;
            this.namepro.SelectedIndexChanged += new System.EventHandler(this.namepro_SelectedIndexChanged);
            // 
            // tpname
            // 
            this.tpname.FormattingEnabled = true;
            this.tpname.Location = new System.Drawing.Point(527, 66);
            this.tpname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpname.Name = "tpname";
            this.tpname.Size = new System.Drawing.Size(155, 24);
            this.tpname.TabIndex = 32;
            this.tpname.SelectedIndexChanged += new System.EventHandler(this.tpname_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Procuct Type:";
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(527, 159);
            this.txt_amount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(103, 22);
            this.txt_amount.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(453, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "Amount:";
            // 
            // listsale
            // 
            this.listsale.BackColor = System.Drawing.SystemColors.HighlightText;
            this.listsale.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.num,
            this.porname,
            this.poramount,
            this.porcost,
            this.porcostall,
            this.ortpname});
            this.listsale.GridLines = true;
            this.listsale.HideSelection = false;
            this.listsale.Location = new System.Drawing.Point(27, 205);
            this.listsale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listsale.Name = "listsale";
            this.listsale.Size = new System.Drawing.Size(912, 230);
            this.listsale.TabIndex = 37;
            this.listsale.UseCompatibleStateImageBehavior = false;
            this.listsale.View = System.Windows.Forms.View.Details;
            this.listsale.DoubleClick += new System.EventHandler(this.listsale_doubleclick);
            // 
            // num
            // 
            this.num.Text = "No.";
            this.num.Width = 101;
            // 
            // porname
            // 
            this.porname.Text = "Product";
            this.porname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.porname.Width = 355;
            // 
            // poramount
            // 
            this.poramount.Text = "Amount";
            this.poramount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.poramount.Width = 125;
            // 
            // porcost
            // 
            this.porcost.Text = "Price Per Unit";
            this.porcost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.porcost.Width = 115;
            // 
            // porcostall
            // 
            this.porcostall.Text = "Total ";
            this.porcostall.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.porcostall.Width = 111;
            // 
            // ortpname
            // 
            this.ortpname.Text = "Type";
            this.ortpname.Width = 138;
            // 
            // txt_allpay
            // 
            this.txt_allpay.Location = new System.Drawing.Point(452, 498);
            this.txt_allpay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_allpay.Name = "txt_allpay";
            this.txt_allpay.Size = new System.Drawing.Size(152, 22);
            this.txt_allpay.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 501);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "Total Items:";
            // 
            // txt_allam
            // 
            this.txt_allam.Location = new System.Drawing.Point(455, 454);
            this.txt_allam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_allam.Name = "txt_allam";
            this.txt_allam.Size = new System.Drawing.Size(149, 22);
            this.txt_allam.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(638, 454);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 16);
            this.label8.TabIndex = 41;
            this.label8.Text = "Baht";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(322, 457);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 16);
            this.label9.TabIndex = 42;
            this.label9.Text = "Total Shopping:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(638, 504);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 16);
            this.label10.TabIndex = 43;
            this.label10.Text = "Unit";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(734, 494);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(133, 30);
            this.btn_save.TabIndex = 44;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_memid
            // 
            this.txt_memid.Location = new System.Drawing.Point(151, 74);
            this.txt_memid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_memid.Name = "txt_memid";
            this.txt_memid.Size = new System.Drawing.Size(132, 22);
            this.txt_memid.TabIndex = 45;
            this.txt_memid.TextChanged += new System.EventHandler(this.txt_memid_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 16);
            this.label11.TabIndex = 46;
            this.label11.Text = "Member ID:";
            // 
            // txt_memname
            // 
            this.txt_memname.Location = new System.Drawing.Point(148, 115);
            this.txt_memname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_memname.Name = "txt_memname";
            this.txt_memname.Size = new System.Drawing.Size(176, 22);
            this.txt_memname.TabIndex = 47;
            this.txt_memname.TextChanged += new System.EventHandler(this.txt_memname_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(51, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 16);
            this.label12.TabIndex = 48;
            this.label12.Text = "Member:";
            // 
            // btn_addpro
            // 
            this.btn_addpro.Location = new System.Drawing.Point(805, 140);
            this.btn_addpro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addpro.Name = "btn_addpro";
            this.btn_addpro.Size = new System.Drawing.Size(123, 31);
            this.btn_addpro.TabIndex = 49;
            this.btn_addpro.Text = "Add";
            this.btn_addpro.UseVisualStyleBackColor = true;
            this.btn_addpro.Click += new System.EventHandler(this.btn_addclick);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.IndianRed;
            this.btn_back.Location = new System.Drawing.Point(816, 16);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(132, 34);
            this.btn_back.TabIndex = 113;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // txt_salemax
            // 
            this.txt_salemax.BackColor = System.Drawing.Color.NavajoWhite;
            this.txt_salemax.Location = new System.Drawing.Point(151, 157);
            this.txt_salemax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_salemax.Name = "txt_salemax";
            this.txt_salemax.Size = new System.Drawing.Size(174, 22);
            this.txt_salemax.TabIndex = 115;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.NavajoWhite;
            this.label13.Location = new System.Drawing.Point(33, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 16);
            this.label13.TabIndex = 114;
            this.label13.Text = "Best Seller :";
            // 
            // sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 562);
            this.Controls.Add(this.txt_salemax);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_addpro);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_memname);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_memid);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_allam);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_allpay);
            this.Controls.Add(this.listsale);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.namepro);
            this.Controls.Add(this.tpname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_bill);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.emname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "sale";
            this.Text = "sale";
            this.Load += new System.EventHandler(this.sale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.ComboBox emname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_bill;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox namepro;
        private System.Windows.Forms.ComboBox tpname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listsale;
        private System.Windows.Forms.ColumnHeader num;
        private System.Windows.Forms.ColumnHeader porname;
        private System.Windows.Forms.ColumnHeader poramount;
        private System.Windows.Forms.ColumnHeader porcost;
        private System.Windows.Forms.ColumnHeader porcostall;
        private System.Windows.Forms.ColumnHeader ortpname;
        private System.Windows.Forms.TextBox txt_allpay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_allam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_memid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_memname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_addpro;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox txt_salemax;
        private System.Windows.Forms.Label label13;
    }
}