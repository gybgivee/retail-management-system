namespace $safeprojectname$
{
    partial class addproduct
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
            this.txt_pcode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_addpro = new System.Windows.Forms.Button();
            this.listsupdetail = new System.Windows.Forms.ListView();
            this.num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.porname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpnames = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pcodes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpcode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_proname = new System.Windows.Forms.TextBox();
            this.tpname = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tpcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_pcode
            // 
            this.txt_pcode.Location = new System.Drawing.Point(604, 166);
            this.txt_pcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_pcode.Name = "txt_pcode";
            this.txt_pcode.Size = new System.Drawing.Size(125, 22);
            this.txt_pcode.TabIndex = 105;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(527, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 104;
            this.label6.Text = "Product ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(427, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 29);
            this.label5.TabIndex = 103;
            this.label5.Text = "Add Product";
            // 
            // btn_addpro
            // 
            this.btn_addpro.Location = new System.Drawing.Point(749, 189);
            this.btn_addpro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addpro.Name = "btn_addpro";
            this.btn_addpro.Size = new System.Drawing.Size(135, 37);
            this.btn_addpro.TabIndex = 102;
            this.btn_addpro.Text = "Product Details";
            this.btn_addpro.UseVisualStyleBackColor = true;
            this.btn_addpro.Click += new System.EventHandler(this.btn_addpro_Click);
            // 
            // listsupdetail
            // 
            this.listsupdetail.BackColor = System.Drawing.SystemColors.HighlightText;
            this.listsupdetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.num,
            this.porname,
            this.tpnames,
            this.pcodes,
            this.tpcode});
            this.listsupdetail.GridLines = true;
            this.listsupdetail.HideSelection = false;
            this.listsupdetail.Location = new System.Drawing.Point(68, 243);
            this.listsupdetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listsupdetail.Name = "listsupdetail";
            this.listsupdetail.Size = new System.Drawing.Size(877, 230);
            this.listsupdetail.TabIndex = 100;
            this.listsupdetail.UseCompatibleStateImageBehavior = false;
            this.listsupdetail.View = System.Windows.Forms.View.Details;
            this.listsupdetail.SelectedIndexChanged += new System.EventHandler(this.listsupdetail_SelectedIndexChanged);
            // 
            // num
            // 
            this.num.Text = "No ID";
            this.num.Width = 72;
            // 
            // porname
            // 
            this.porname.Text = "Product Name";
            this.porname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.porname.Width = 269;
            // 
            // tpnames
            // 
            this.tpnames.Text = "Product Type";
            this.tpnames.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tpnames.Width = 191;
            // 
            // pcodes
            // 
            this.pcodes.Text = "Product ID";
            this.pcodes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pcodes.Width = 208;
            // 
            // tpcode
            // 
            this.tpcode.Text = "Product Type ID";
            this.tpcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tpcode.Width = 130;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 99;
            this.label1.Text = "Product Name:";
            // 
            // txt_proname
            // 
            this.txt_proname.Location = new System.Drawing.Point(276, 168);
            this.txt_proname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_proname.Name = "txt_proname";
            this.txt_proname.Size = new System.Drawing.Size(213, 22);
            this.txt_proname.TabIndex = 98;
            this.txt_proname.TextChanged += new System.EventHandler(this.txt_proname_TextChanged);
            // 
            // tpname
            // 
            this.tpname.FormattingEnabled = true;
            this.tpname.Location = new System.Drawing.Point(276, 104);
            this.tpname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpname.Name = "tpname";
            this.tpname.Size = new System.Drawing.Size(155, 24);
            this.tpname.TabIndex = 96;
            this.tpname.SelectedIndexChanged += new System.EventHandler(this.tpname_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 95;
            this.label3.Text = "Product Type:";
            // 
            // txt_tpcode
            // 
            this.txt_tpcode.Location = new System.Drawing.Point(604, 109);
            this.txt_tpcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tpcode.Name = "txt_tpcode";
            this.txt_tpcode.Size = new System.Drawing.Size(125, 22);
            this.txt_tpcode.TabIndex = 107;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 106;
            this.label2.Text = "Product Type ID:";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(749, 502);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(164, 37);
            this.btn_save.TabIndex = 108;
            this.btn_save.Text = "Added Products Successfully";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.LightCoral;
            this.btn_back.Location = new System.Drawing.Point(796, 34);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(132, 34);
            this.btn_back.TabIndex = 109;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // addproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 560);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_tpcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_pcode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_addpro);
            this.Controls.Add(this.listsupdetail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_proname);
            this.Controls.Add(this.tpname);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "addproduct";
            this.Text = "addproduct";
            this.Load += new System.EventHandler(this.addproduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_pcode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_addpro;
        private System.Windows.Forms.ListView listsupdetail;
        private System.Windows.Forms.ColumnHeader num;
        private System.Windows.Forms.ColumnHeader porname;
        private System.Windows.Forms.ColumnHeader tpnames;
        private System.Windows.Forms.ColumnHeader pcodes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_proname;
        private System.Windows.Forms.ComboBox tpname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader tpcode;
        private System.Windows.Forms.TextBox txt_tpcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_back;
    }
}