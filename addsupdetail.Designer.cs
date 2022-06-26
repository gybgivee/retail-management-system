namespace $safeprojectname$
{
    partial class addsupdetail
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
            this.label4 = new System.Windows.Forms.Label();
            this.namepro = new System.Windows.Forms.ComboBox();
            this.tpname = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_supname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listsupdetail = new System.Windows.Forms.ListView();
            this.num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.porname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.porcost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ortpname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_supcost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_addpro = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_supcode = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Product Name:";
            // 
            // namepro
            // 
            this.namepro.FormattingEnabled = true;
            this.namepro.Location = new System.Drawing.Point(342, 154);
            this.namepro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.namepro.Name = "namepro";
            this.namepro.Size = new System.Drawing.Size(171, 24);
            this.namepro.TabIndex = 14;
            this.namepro.SelectedIndexChanged += new System.EventHandler(this.namepro_SelectedIndexChanged);
            // 
            // tpname
            // 
            this.tpname.FormattingEnabled = true;
            this.tpname.Location = new System.Drawing.Point(342, 114);
            this.tpname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpname.Name = "tpname";
            this.tpname.Size = new System.Drawing.Size(155, 24);
            this.tpname.TabIndex = 13;
            this.tpname.SelectedIndexChanged += new System.EventHandler(this.tpname_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Product Type:";
            // 
            // txt_supname
            // 
            this.txt_supname.Location = new System.Drawing.Point(342, 73);
            this.txt_supname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_supname.Name = "txt_supname";
            this.txt_supname.Size = new System.Drawing.Size(241, 22);
            this.txt_supname.TabIndex = 85;
            this.txt_supname.TextChanged += new System.EventHandler(this.txt_supname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 86;
            this.label1.Text = "Supplier:";
            // 
            // listsupdetail
            // 
            this.listsupdetail.BackColor = System.Drawing.SystemColors.HighlightText;
            this.listsupdetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.num,
            this.porname,
            this.porcost,
            this.ortpname});
            this.listsupdetail.GridLines = true;
            this.listsupdetail.HideSelection = false;
            this.listsupdetail.Location = new System.Drawing.Point(132, 249);
            this.listsupdetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listsupdetail.Name = "listsupdetail";
            this.listsupdetail.Size = new System.Drawing.Size(777, 230);
            this.listsupdetail.TabIndex = 87;
            this.listsupdetail.UseCompatibleStateImageBehavior = false;
            this.listsupdetail.View = System.Windows.Forms.View.Details;
            this.listsupdetail.SelectedIndexChanged += new System.EventHandler(this.listsupdetail_SelectedIndexChanged);
            this.listsupdetail.DoubleClick += new System.EventHandler(this.listsupdetail_doubleclick);
            // 
            // num
            // 
            this.num.Text = "No ID";
            this.num.Width = 101;
            // 
            // porname
            // 
            this.porname.Text = "Product";
            this.porname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.porname.Width = 269;
            // 
            // porcost
            // 
            this.porcost.Text = "Cost Price/Unit";
            this.porcost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.porcost.Width = 191;
            // 
            // ortpname
            // 
            this.ortpname.Text = "Product Type";
            this.ortpname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ortpname.Width = 208;
            // 
            // txt_supcost
            // 
            this.txt_supcost.Location = new System.Drawing.Point(342, 197);
            this.txt_supcost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_supcost.Name = "txt_supcost";
            this.txt_supcost.Size = new System.Drawing.Size(168, 22);
            this.txt_supcost.TabIndex = 88;
            this.txt_supcost.TextChanged += new System.EventHandler(this.txt_supcost_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 89;
            this.label2.Text = "Cost Price:";
            // 
            // btn_addpro
            // 
            this.btn_addpro.Location = new System.Drawing.Point(620, 191);
            this.btn_addpro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addpro.Name = "btn_addpro";
            this.btn_addpro.Size = new System.Drawing.Size(135, 37);
            this.btn_addpro.TabIndex = 90;
            this.btn_addpro.Text = "Add";
            this.btn_addpro.UseVisualStyleBackColor = true;
            this.btn_addpro.Click += new System.EventHandler(this.btn_addpro_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(466, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 29);
            this.label5.TabIndex = 91;
            this.label5.Text = "Add Product";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(692, 494);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(164, 37);
            this.btn_save.TabIndex = 92;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(598, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 93;
            this.label6.Text = "Supplier :";
            // 
            // txt_supcode
            // 
            this.txt_supcode.Location = new System.Drawing.Point(732, 78);
            this.txt_supcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_supcode.Name = "txt_supcode";
            this.txt_supcode.Size = new System.Drawing.Size(125, 22);
            this.txt_supcode.TabIndex = 94;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.LightCoral;
            this.btn_back.Location = new System.Drawing.Point(792, 22);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(132, 34);
            this.btn_back.TabIndex = 112;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // addsupdetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 554);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.txt_supcode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_addpro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_supcost);
            this.Controls.Add(this.listsupdetail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_supname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.namepro);
            this.Controls.Add(this.tpname);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "addsupdetail";
            this.Text = "addsupdetail";
            this.Load += new System.EventHandler(this.addsupdetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox namepro;
        private System.Windows.Forms.ComboBox tpname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_supname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listsupdetail;
        private System.Windows.Forms.ColumnHeader num;
        private System.Windows.Forms.ColumnHeader porname;
        private System.Windows.Forms.ColumnHeader porcost;
        private System.Windows.Forms.ColumnHeader ortpname;
        private System.Windows.Forms.TextBox txt_supcost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_addpro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_supcode;
        private System.Windows.Forms.Button btn_back;
    }
}