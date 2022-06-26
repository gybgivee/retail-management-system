namespace $safeprojectname$
{
    partial class product
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
            this.listviewpro = new System.Windows.Forms.ListView();
            this.typeid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.typename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_find = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.type_find = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listviewpro
            // 
            this.listviewpro.BackColor = System.Drawing.Color.LightBlue;
            this.listviewpro.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.typeid,
            this.typename,
            this.id,
            this.name,
            this.amount,
            this.cost,
            this.price});
            this.listviewpro.GridLines = true;
            this.listviewpro.HideSelection = false;
            this.listviewpro.Location = new System.Drawing.Point(74, 213);
            this.listviewpro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listviewpro.Name = "listviewpro";
            this.listviewpro.Size = new System.Drawing.Size(778, 232);
            this.listviewpro.TabIndex = 14;
            this.listviewpro.UseCompatibleStateImageBehavior = false;
            this.listviewpro.View = System.Windows.Forms.View.Details;
            this.listviewpro.SelectedIndexChanged += new System.EventHandler(this.listviewpro_SelectedIndexChanged);
            // 
            // typeid
            // 
            this.typeid.Text = "Type ID";
            this.typeid.Width = 130;
            // 
            // typename
            // 
            this.typename.Text = "Name";
            this.typename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.typename.Width = 165;
            // 
            // id
            // 
            this.id.Text = "Product ID";
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.id.Width = 92;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name.Width = 110;
            // 
            // amount
            // 
            this.amount.Text = "Amount";
            this.amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.amount.Width = 124;
            // 
            // cost
            // 
            this.cost.Text = "Cost";
            this.cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cost.Width = 130;
            // 
            // price
            // 
            this.price.Text = "Retail Price";
            this.price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.price.Width = 114;
            // 
            // txt_find
            // 
            this.txt_find.Location = new System.Drawing.Point(392, 137);
            this.txt_find.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_find.Name = "txt_find";
            this.txt_find.Size = new System.Drawing.Size(148, 22);
            this.txt_find.TabIndex = 13;
            this.txt_find.TextChanged += new System.EventHandler(this.txt_find_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Search:";
            // 
            // type_find
            // 
            this.type_find.FormattingEnabled = true;
            this.type_find.Items.AddRange(new object[] {
            "Product Name",
            "Retail Price"});
            this.type_find.Location = new System.Drawing.Point(392, 82);
            this.type_find.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.type_find.Name = "type_find";
            this.type_find.Size = new System.Drawing.Size(203, 24);
            this.type_find.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Search Option:";
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(643, 137);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(108, 30);
            this.btnsearch.TabIndex = 9;
            this.btnsearch.Text = "OK";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 554);
            this.Controls.Add(this.listviewpro);
            this.Controls.Add(this.txt_find);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.type_find);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsearch);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "product";
            this.Text = "product";
            this.Load += new System.EventHandler(this.product_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listviewpro;
        private System.Windows.Forms.ColumnHeader typeid;
        private System.Windows.Forms.ColumnHeader typename;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader amount;
        private System.Windows.Forms.ColumnHeader cost;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.TextBox txt_find;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox type_find;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsearch;
    }
}