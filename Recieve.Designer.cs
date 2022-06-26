namespace $safeprojectname$
{
    partial class Recieve
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
            this.label8 = new System.Windows.Forms.Label();
            this.suppname = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.namepro = new System.Windows.Forms.ComboBox();
            this.tpname = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.liststock = new System.Windows.Forms.ListView();
            this.num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.porname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.poramount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.porcost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.porcostall = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.porsupname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ortpname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addpro = new System.Windows.Forms.Button();
            this.emname = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pecode = new System.Windows.Forms.ComboBox();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_allam = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_allpay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(464, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 38;
            this.label8.Text = "Supplier:";
            // 
            // suppname
            // 
            this.suppname.FormattingEnabled = true;
            this.suppname.Location = new System.Drawing.Point(576, 154);
            this.suppname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.suppname.Name = "suppname";
            this.suppname.Size = new System.Drawing.Size(189, 24);
            this.suppname.TabIndex = 37;
            this.suppname.SelectedIndexChanged += new System.EventHandler(this.suppname_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(469, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Amount:";
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(576, 194);
            this.txt_amount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(124, 22);
            this.txt_amount.TabIndex = 33;
            this.txt_amount.TextChanged += new System.EventHandler(this.txt_amont_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(468, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Product:";
            // 
            // namepro
            // 
            this.namepro.FormattingEnabled = true;
            this.namepro.Location = new System.Drawing.Point(576, 119);
            this.namepro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.namepro.Name = "namepro";
            this.namepro.Size = new System.Drawing.Size(189, 24);
            this.namepro.TabIndex = 31;
            this.namepro.SelectedIndexChanged += new System.EventHandler(this.namepro_SelectedIndexChanged);
            // 
            // tpname
            // 
            this.tpname.FormattingEnabled = true;
            this.tpname.Location = new System.Drawing.Point(576, 67);
            this.tpname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpname.Name = "tpname";
            this.tpname.Size = new System.Drawing.Size(155, 24);
            this.tpname.TabIndex = 30;
            this.tpname.SelectedIndexChanged += new System.EventHandler(this.tpname_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Type:";
            // 
            // liststock
            // 
            this.liststock.BackColor = System.Drawing.SystemColors.HighlightText;
            this.liststock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.num,
            this.porname,
            this.poramount,
            this.porcost,
            this.porcostall,
            this.porsupname,
            this.ortpname});
            this.liststock.GridLines = true;
            this.liststock.HideSelection = false;
            this.liststock.Location = new System.Drawing.Point(82, 234);
            this.liststock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.liststock.Name = "liststock";
            this.liststock.Size = new System.Drawing.Size(888, 230);
            this.liststock.TabIndex = 28;
            this.liststock.UseCompatibleStateImageBehavior = false;
            this.liststock.View = System.Windows.Forms.View.Details;
            this.liststock.SelectedIndexChanged += new System.EventHandler(this.listbuy_SelectedIndexChanged);
            this.liststock.DoubleClick += new System.EventHandler(this.liststock_doubleclick);
            // 
            // num
            // 
            this.num.Text = "No";
            this.num.Width = 72;
            // 
            // porname
            // 
            this.porname.Text = "Product Name";
            this.porname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.porname.Width = 125;
            // 
            // poramount
            // 
            this.poramount.Text = "Amount";
            this.poramount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.poramount.Width = 98;
            // 
            // porcost
            // 
            this.porcost.Text = "Price per Unit";
            this.porcost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.porcost.Width = 115;
            // 
            // porcostall
            // 
            this.porcostall.Text = "Total ";
            this.porcostall.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.porcostall.Width = 98;
            // 
            // porsupname
            // 
            this.porsupname.Text = "Supplier Name";
            this.porsupname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.porsupname.Width = 234;
            // 
            // ortpname
            // 
            this.ortpname.Text = "Type name";
            this.ortpname.Width = 138;
            // 
            // addpro
            // 
            this.addpro.Location = new System.Drawing.Point(776, 184);
            this.addpro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addpro.Name = "addpro";
            this.addpro.Size = new System.Drawing.Size(149, 35);
            this.addpro.TabIndex = 26;
            this.addpro.Text = "Add";
            this.addpro.UseVisualStyleBackColor = true;
            this.addpro.Click += new System.EventHandler(this.btn_addpro);
            // 
            // emname
            // 
            this.emname.FormattingEnabled = true;
            this.emname.Location = new System.Drawing.Point(221, 126);
            this.emname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emname.Name = "emname";
            this.emname.Size = new System.Drawing.Size(160, 24);
            this.emname.TabIndex = 59;
            this.emname.SelectedIndexChanged += new System.EventHandler(this.emname_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 58;
            this.label1.Text = "Employee:";
            // 
            // pecode
            // 
            this.pecode.FormattingEnabled = true;
            this.pecode.Location = new System.Drawing.Point(221, 184);
            this.pecode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pecode.Name = "pecode";
            this.pecode.Size = new System.Drawing.Size(164, 24);
            this.pecode.TabIndex = 57;
            this.pecode.SelectedIndexChanged += new System.EventHandler(this.pecode_SelectedIndexChanged);
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(221, 64);
            this.txt_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(160, 22);
            this.txt_date.TabIndex = 56;
            this.txt_date.TextChanged += new System.EventHandler(this.txt_date_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 55;
            this.label2.Text = "Pay Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 54;
            this.label6.Text = "No :";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(765, 502);
            this.save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(177, 39);
            this.save.TabIndex = 60;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.btn_sayepe);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(678, 483);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 16);
            this.label10.TabIndex = 66;
            this.label10.Text = "Unit";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(396, 483);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 65;
            this.label9.Text = "Total Items:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(678, 527);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 16);
            this.label7.TabIndex = 64;
            this.label7.Text = "Baht";
            // 
            // txt_allam
            // 
            this.txt_allam.Location = new System.Drawing.Point(510, 483);
            this.txt_allam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_allam.Name = "txt_allam";
            this.txt_allam.Size = new System.Drawing.Size(149, 22);
            this.txt_allam.TabIndex = 63;
            this.txt_allam.TextChanged += new System.EventHandler(this.txt_allam_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(396, 527);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 16);
            this.label11.TabIndex = 62;
            this.label11.Text = "Total Credit:";
            // 
            // txt_allpay
            // 
            this.txt_allpay.Location = new System.Drawing.Point(508, 521);
            this.txt_allpay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_allpay.Name = "txt_allpay";
            this.txt_allpay.Size = new System.Drawing.Size(152, 22);
            this.txt_allpay.TabIndex = 61;
            // 
            // Recieve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 578);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_allam);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_allpay);
            this.Controls.Add(this.save);
            this.Controls.Add(this.emname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pecode);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.suppname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.namepro);
            this.Controls.Add(this.tpname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.liststock);
            this.Controls.Add(this.addpro);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Recieve";
            this.Text = "Recieve";
            this.Load += new System.EventHandler(this.Recieve_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox suppname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox namepro;
        private System.Windows.Forms.ComboBox tpname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView liststock;
        private System.Windows.Forms.ColumnHeader num;
        private System.Windows.Forms.ColumnHeader porname;
        private System.Windows.Forms.ColumnHeader poramount;
        private System.Windows.Forms.ColumnHeader porcost;
        private System.Windows.Forms.ColumnHeader porcostall;
        private System.Windows.Forms.ColumnHeader porsupname;
        private System.Windows.Forms.ColumnHeader ortpname;
        private System.Windows.Forms.Button addpro;
        private System.Windows.Forms.ComboBox emname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox pecode;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_allam;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_allpay;
    }
}