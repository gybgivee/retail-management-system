namespace $safeprojectname$
{
    partial class Buy
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
            this.addpro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listbuy = new System.Windows.Forms.ListView();
            this.num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.porname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.poramount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.porcost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.porcostall = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.porsupname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ortpname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.tpname = new System.Windows.Forms.ComboBox();
            this.namepro = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.emname = new System.Windows.Forms.ComboBox();
            this.suppname = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.orcode = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_allam = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_allpay = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Receipt :";
            // 
            // addpro
            // 
            this.addpro.Location = new System.Drawing.Point(707, 143);
            this.addpro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addpro.Name = "addpro";
            this.addpro.Size = new System.Drawing.Size(149, 35);
            this.addpro.TabIndex = 2;
            this.addpro.Text = "Add Product";
            this.addpro.UseVisualStyleBackColor = true;
            this.addpro.Click += new System.EventHandler(this.btn_addpro);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Order date :";
            // 
            // listbuy
            // 
            this.listbuy.BackColor = System.Drawing.SystemColors.HighlightText;
            this.listbuy.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.num,
            this.porname,
            this.poramount,
            this.porcost,
            this.porcostall,
            this.porsupname,
            this.ortpname});
            this.listbuy.GridLines = true;
            this.listbuy.HideSelection = false;
            this.listbuy.Location = new System.Drawing.Point(29, 201);
            this.listbuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listbuy.Name = "listbuy";
            this.listbuy.Size = new System.Drawing.Size(894, 230);
            this.listbuy.TabIndex = 6;
            this.listbuy.UseCompatibleStateImageBehavior = false;
            this.listbuy.View = System.Windows.Forms.View.Details;
            this.listbuy.DoubleClick += new System.EventHandler(this.listbuy_DoubleClick);
            // 
            // num
            // 
            this.num.Text = "No.";
            this.num.Width = 84;
            // 
            // porname
            // 
            this.porname.Text = "Product";
            this.porname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.porname.Width = 125;
            // 
            // poramount
            // 
            this.poramount.Text = "Amount";
            this.poramount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.poramount.Width = 125;
            // 
            // porcost
            // 
            this.porcost.Text = "Price/unit";
            this.porcost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.porcost.Width = 115;
            // 
            // porcostall
            // 
            this.porcostall.Text = "Total ";
            this.porcostall.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.porcostall.Width = 111;
            // 
            // porsupname
            // 
            this.porsupname.Text = "Supplier";
            this.porsupname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.porsupname.Width = 221;
            // 
            // ortpname
            // 
            this.ortpname.Text = "Product type";
            this.ortpname.Width = 138;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Product Type:";
            // 
            // tpname
            // 
            this.tpname.FormattingEnabled = true;
            this.tpname.Location = new System.Drawing.Point(557, 46);
            this.tpname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpname.Name = "tpname";
            this.tpname.Size = new System.Drawing.Size(155, 24);
            this.tpname.TabIndex = 9;
            this.tpname.SelectedIndexChanged += new System.EventHandler(this.tpname_SelectedIndexChanged);
            // 
            // namepro
            // 
            this.namepro.FormattingEnabled = true;
            this.namepro.Location = new System.Drawing.Point(556, 82);
            this.namepro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.namepro.Name = "namepro";
            this.namepro.Size = new System.Drawing.Size(171, 24);
            this.namepro.TabIndex = 10;
            this.namepro.SelectedIndexChanged += new System.EventHandler(this.pname_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Product Name:";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(707, 482);
            this.save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(169, 31);
            this.save.TabIndex = 12;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.btn_savepro);
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(557, 160);
            this.txt_amount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(103, 22);
            this.txt_amount.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(444, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Amount:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Employee Name:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // emname
            // 
            this.emname.FormattingEnabled = true;
            this.emname.Location = new System.Drawing.Point(155, 152);
            this.emname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emname.Name = "emname";
            this.emname.Size = new System.Drawing.Size(164, 24);
            this.emname.TabIndex = 17;
            this.emname.SelectedIndexChanged += new System.EventHandler(this.emname_SelectedIndexChanged);
            // 
            // suppname
            // 
            this.suppname.FormattingEnabled = true;
            this.suppname.Location = new System.Drawing.Point(557, 122);
            this.suppname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.suppname.Name = "suppname";
            this.suppname.Size = new System.Drawing.Size(103, 24);
            this.suppname.TabIndex = 20;
            this.suppname.SelectedIndexChanged += new System.EventHandler(this.supname_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(444, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Supplier:";
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(155, 53);
            this.txt_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(160, 22);
            this.txt_date.TabIndex = 23;
            this.txt_date.TextChanged += new System.EventHandler(this.txt_date_TextChanged);
            // 
            // orcode
            // 
            this.orcode.FormattingEnabled = true;
            this.orcode.Location = new System.Drawing.Point(155, 103);
            this.orcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orcode.Name = "orcode";
            this.orcode.Size = new System.Drawing.Size(164, 24);
            this.orcode.TabIndex = 24;
            this.orcode.SelectedIndexChanged += new System.EventHandler(this.orcode_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(635, 465);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 16);
            this.label10.TabIndex = 49;
            this.label10.Text = "unit";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(353, 465);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 48;
            this.label9.Text = "Total Amount:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(635, 515);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 47;
            this.label7.Text = "Thai baht";
            // 
            // txt_allam
            // 
            this.txt_allam.Location = new System.Drawing.Point(473, 467);
            this.txt_allam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_allam.Name = "txt_allam";
            this.txt_allam.Size = new System.Drawing.Size(149, 22);
            this.txt_allam.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(353, 509);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 16);
            this.label11.TabIndex = 45;
            this.label11.Text = "Total Cost:";
            // 
            // txt_allpay
            // 
            this.txt_allpay.Location = new System.Drawing.Point(470, 509);
            this.txt_allpay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_allpay.Name = "txt_allpay";
            this.txt_allpay.Size = new System.Drawing.Size(152, 22);
            this.txt_allpay.TabIndex = 44;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.LightCoral;
            this.btn_back.Location = new System.Drawing.Point(744, 20);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(132, 34);
            this.btn_back.TabIndex = 110;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 565);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_allam);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_allpay);
            this.Controls.Add(this.orcode);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.suppname);
            this.Controls.Add(this.emname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.namepro);
            this.Controls.Add(this.tpname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listbuy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addpro);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Buy";
            this.Text = "Buy";
            this.Load += new System.EventHandler(this.Buy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addpro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listbuy;
        private System.Windows.Forms.ColumnHeader num;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tpname;
        private System.Windows.Forms.ColumnHeader porname;
        private System.Windows.Forms.ColumnHeader poramount;
        private System.Windows.Forms.ComboBox namepro;
        private System.Windows.Forms.Label label4;
       private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox emname;
        private System.Windows.Forms.ColumnHeader porcost;
        private System.Windows.Forms.ComboBox suppname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader porcostall;
        private System.Windows.Forms.ColumnHeader porsupname;
        private System.Windows.Forms.ColumnHeader ortpname;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.ComboBox orcode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_allam;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_allpay;
        private System.Windows.Forms.Button btn_back;
    }
}