namespace $safeprojectname$
{
    partial class datasup
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
            this.listviewsup = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pcode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listviewsup
            // 
            this.listviewsup.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listviewsup.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name,
            this.contact,
            this.tpname,
            this.pcode,
            this.pname});
            this.listviewsup.GridLines = true;
            this.listviewsup.Location = new System.Drawing.Point(44, 113);
            this.listviewsup.Name = "listviewsup";
            this.listviewsup.Size = new System.Drawing.Size(1042, 485);
            this.listviewsup.TabIndex = 1;
            this.listviewsup.UseCompatibleStateImageBehavior = false;
            this.listviewsup.View = System.Windows.Forms.View.Details;
            this.listviewsup.SelectedIndexChanged += new System.EventHandler(this.listviewsup_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "No.";
            this.id.Width = 72;
            // 
            // name
            // 
            this.name.Text = "Product";
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name.Width = 175;
            // 
            // contact
            // 
            this.contact.Text = "Type";
            this.contact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.contact.Width = 176;
            // 
            // tpname
            // 
            this.tpname.Text = "Supplier ID";
            this.tpname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tpname.Width = 165;
            // 
            // pcode
            // 
            this.pcode.Text = "Supplier";
            this.pcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pcode.Width = 232;
            // 
            // pname
            // 
            this.pname.Text = "Contact";
            this.pname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pname.Width = 214;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(840, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Contact Details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // datasup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 672);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listviewsup);
            this.Name = "datasup";
            this.Text = "datasup";
            this.Load += new System.EventHandler(this.datasup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listviewsup;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader contact;
        private System.Windows.Forms.ColumnHeader tpname;
        private System.Windows.Forms.ColumnHeader pcode;
        private System.Windows.Forms.ColumnHeader pname;
        private System.Windows.Forms.Button button1;
    }
}