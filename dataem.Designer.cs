namespace $safeprojectname$
{
    partial class dataem
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label9 = new System.Windows.Forms.Label();
            this.find_search = new System.Windows.Forms.ComboBox();
            this.find_type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_find = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_find = new System.Windows.Forms.TextBox();
            this.btn_registor = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.find_per = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name,
            this.address,
            this.status});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(67, 211);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(845, 265);
            this.listView1.TabIndex = 36;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Tag = "";
            this.id.Text = "ID";
            this.id.Width = 160;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name.Width = 157;
            // 
            // address
            // 
            this.address.Text = "Address";
            this.address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.address.Width = 315;
            // 
            // status
            // 
            this.status.Text = "Status";
            this.status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.status.Width = 135;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.Location = new System.Drawing.Point(236, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Search:";
            // 
            // find_search
            // 
            this.find_search.FormattingEnabled = true;
            this.find_search.Items.AddRange(new object[] {
            "ID",
            "Name",
            ""});
            this.find_search.Location = new System.Drawing.Point(336, 105);
            this.find_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.find_search.Name = "find_search";
            this.find_search.Size = new System.Drawing.Size(151, 24);
            this.find_search.TabIndex = 34;
            this.find_search.SelectedIndexChanged += new System.EventHandler(this.find_search_SelectedIndexChanged);
            // 
            // find_type
            // 
            this.find_type.FormattingEnabled = true;
            this.find_type.Items.AddRange(new object[] {
            "Employee",
            "Supervisor",
            "Manager"});
            this.find_type.Location = new System.Drawing.Point(336, 67);
            this.find_type.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.find_type.Name = "find_type";
            this.find_type.Size = new System.Drawing.Size(151, 24);
            this.find_type.TabIndex = 33;
            this.find_type.SelectedIndexChanged += new System.EventHandler(this.find_type_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(191, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Search Type:";
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(552, 140);
            this.btn_find.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(91, 36);
            this.btn_find.TabIndex = 31;
            this.btn_find.Text = "OK";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.Location = new System.Drawing.Point(232, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Search:";
            // 
            // txt_find
            // 
            this.txt_find.Location = new System.Drawing.Point(336, 147);
            this.txt_find.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_find.Name = "txt_find";
            this.txt_find.Size = new System.Drawing.Size(164, 22);
            this.txt_find.TabIndex = 29;
            this.txt_find.TextChanged += new System.EventHandler(this.txt_find_TextChanged);
            // 
            // btn_registor
            // 
            this.btn_registor.Location = new System.Drawing.Point(737, 26);
            this.btn_registor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_registor.Name = "btn_registor";
            this.btn_registor.Size = new System.Drawing.Size(128, 39);
            this.btn_registor.TabIndex = 28;
            this.btn_registor.Text = "Registration";
            this.btn_registor.UseVisualStyleBackColor = true;
            this.btn_registor.Click += new System.EventHandler(this.btn_registor_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(173, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Search Options:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // find_per
            // 
            this.find_per.FormattingEnabled = true;
            this.find_per.Items.AddRange(new object[] {
            "Individual",
            "All"});
            this.find_per.Location = new System.Drawing.Point(336, 26);
            this.find_per.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.find_per.Name = "find_per";
            this.find_per.Size = new System.Drawing.Size(151, 24);
            this.find_per.TabIndex = 26;
            this.find_per.SelectedIndexChanged += new System.EventHandler(this.find_per_SelectedIndexChanged);
            // 
            // dataem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 523);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.find_search);
            this.Controls.Add(this.find_type);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_find);
            this.Controls.Add(this.btn_registor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.find_per);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "dataem";
            this.Text = "dataem";
            this.Load += new System.EventHandler(this.dataem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader address;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox find_search;
        private System.Windows.Forms.ComboBox find_type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_find;
        private System.Windows.Forms.Button btn_registor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox find_per;
    }
}