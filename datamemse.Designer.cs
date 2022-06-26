namespace $safeprojectname$
{
    partial class datamemse
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
            this.find_type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_find = new System.Windows.Forms.TextBox();
            this.listmem = new System.Windows.Forms.ListView();
            this.mid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mgen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mstatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.msh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mpay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_ = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.find_per = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // find_type
            // 
            this.find_type.FormattingEnabled = true;
            this.find_type.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Gender",
            "Status",
            "Stock Amount"});
            this.find_type.Location = new System.Drawing.Point(420, 91);
            this.find_type.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.find_type.Name = "find_type";
            this.find_type.Size = new System.Drawing.Size(151, 24);
            this.find_type.TabIndex = 35;
            this.find_type.SelectedIndexChanged += new System.EventHandler(this.find_type_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(292, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Search Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.Location = new System.Drawing.Point(333, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "Search:";
            // 
            // txt_find
            // 
            this.txt_find.Location = new System.Drawing.Point(420, 147);
            this.txt_find.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_find.Name = "txt_find";
            this.txt_find.Size = new System.Drawing.Size(164, 22);
            this.txt_find.TabIndex = 36;
            this.txt_find.TextChanged += new System.EventHandler(this.txt_find_TextChanged);
            // 
            // listmem
            // 
            this.listmem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mid,
            this.mname,
            this.mgen,
            this.mstatus,
            this.msh,
            this.value,
            this.mpay});
            this.listmem.HideSelection = false;
            this.listmem.Location = new System.Drawing.Point(90, 226);
            this.listmem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listmem.Name = "listmem";
            this.listmem.Size = new System.Drawing.Size(811, 217);
            this.listmem.TabIndex = 38;
            this.listmem.UseCompatibleStateImageBehavior = false;
            this.listmem.View = System.Windows.Forms.View.Details;
            // 
            // mid
            // 
            this.mid.Text = "ID";
            this.mid.Width = 93;
            // 
            // mname
            // 
            this.mname.Text = "Name";
            this.mname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mname.Width = 210;
            // 
            // mgen
            // 
            this.mgen.Text = "Gender";
            this.mgen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mgen.Width = 95;
            // 
            // mstatus
            // 
            this.mstatus.Text = "Status";
            this.mstatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mstatus.Width = 149;
            // 
            // msh
            // 
            this.msh.Text = "Stock";
            this.msh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.msh.Width = 146;
            // 
            // value
            // 
            this.value.Text = "Total";
            this.value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.value.Width = 122;
            // 
            // mpay
            // 
            this.mpay.Text = "Dividen";
            this.mpay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mpay.Width = 93;
            // 
            // btn_
            // 
            this.btn_.Location = new System.Drawing.Point(670, 143);
            this.btn_.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_.Name = "btn_";
            this.btn_.Size = new System.Drawing.Size(125, 35);
            this.btn_.TabIndex = 39;
            this.btn_.Text = "OK";
            this.btn_.UseVisualStyleBackColor = true;
            this.btn_.Click += new System.EventHandler(this.btn__Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(270, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "Search Options:";
            // 
            // find_per
            // 
            this.find_per.FormattingEnabled = true;
            this.find_per.Items.AddRange(new object[] {
            "Individual",
            "All"});
            this.find_per.Location = new System.Drawing.Point(420, 38);
            this.find_per.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.find_per.Name = "find_per";
            this.find_per.Size = new System.Drawing.Size(151, 24);
            this.find_per.TabIndex = 40;
            this.find_per.SelectedIndexChanged += new System.EventHandler(this.find_per_SelectedIndexChanged);
            // 
            // datamemse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 541);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.find_per);
            this.Controls.Add(this.btn_);
            this.Controls.Add(this.listmem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_find);
            this.Controls.Add(this.find_type);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "datamemse";
            this.Text = "datamemse";
            this.Load += new System.EventHandler(this.datamemse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox find_type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_find;
        private System.Windows.Forms.ListView listmem;
        private System.Windows.Forms.ColumnHeader mid;
        private System.Windows.Forms.ColumnHeader mname;
        private System.Windows.Forms.ColumnHeader mgen;
        private System.Windows.Forms.ColumnHeader mstatus;
        private System.Windows.Forms.ColumnHeader msh;
        private System.Windows.Forms.ColumnHeader value;
        private System.Windows.Forms.Button btn_;
        private System.Windows.Forms.ColumnHeader mpay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox find_per;
    }
}