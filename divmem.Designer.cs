﻿namespace $safeprojectname$
{
    partial class divmem
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
            this.btn_search = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dateend = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.datestart = new System.Windows.Forms.DateTimePicker();
            this.listdiv = new System.Windows.Forms.ListView();
            this.num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pstart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pend = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ppro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ppay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.em = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(867, 109);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(105, 31);
            this.btn_search.TabIndex = 115;
            this.btn_search.Text = "Calculate";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(520, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 16);
            this.label8.TabIndex = 114;
            this.label8.Text = "Until:";
            // 
            // dateend
            // 
            this.dateend.CustomFormat = "yyyy-MM-dd";
            this.dateend.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateend.Location = new System.Drawing.Point(636, 111);
            this.dateend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateend.Name = "dateend";
            this.dateend.Size = new System.Drawing.Size(178, 22);
            this.dateend.TabIndex = 113;
            this.dateend.ValueChanged += new System.EventHandler(this.dateend_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 112;
            this.label4.Text = "From :";
            // 
            // datestart
            // 
            this.datestart.CustomFormat = "yyyy-MM-dd";
            this.datestart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datestart.Location = new System.Drawing.Point(299, 111);
            this.datestart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datestart.Name = "datestart";
            this.datestart.Size = new System.Drawing.Size(178, 22);
            this.datestart.TabIndex = 111;
            this.datestart.ValueChanged += new System.EventHandler(this.datestart_ValueChanged);
            // 
            // listdiv
            // 
            this.listdiv.BackColor = System.Drawing.SystemColors.HighlightText;
            this.listdiv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.num,
            this.pdate,
            this.pstart,
            this.pend,
            this.ppro,
            this.ppay,
            this.em,
            this.mid});
            this.listdiv.GridLines = true;
            this.listdiv.HideSelection = false;
            this.listdiv.Location = new System.Drawing.Point(21, 183);
            this.listdiv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listdiv.Name = "listdiv";
            this.listdiv.Size = new System.Drawing.Size(1077, 230);
            this.listdiv.TabIndex = 116;
            this.listdiv.UseCompatibleStateImageBehavior = false;
            this.listdiv.View = System.Windows.Forms.View.Details;
            // 
            // num
            // 
            this.num.Text = "No.";
            this.num.Width = 108;
            // 
            // pdate
            // 
            this.pdate.Text = "Recieve Date";
            this.pdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pdate.Width = 137;
            // 
            // pstart
            // 
            this.pstart.Text = "From";
            this.pstart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pstart.Width = 158;
            // 
            // pend
            // 
            this.pend.Text = "Until";
            this.pend.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pend.Width = 132;
            // 
            // ppro
            // 
            this.ppro.Text = "% Dividend";
            this.ppro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ppro.Width = 115;
            // 
            // ppay
            // 
            this.ppay.Text = "Recieve Amount";
            this.ppay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ppay.Width = 150;
            // 
            // em
            // 
            this.em.Text = "Employee";
            this.em.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.em.Width = 131;
            // 
            // mid
            // 
            this.mid.Text = "Member";
            this.mid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mid.Width = 160;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(507, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 117;
            this.label1.Text = "Calculate dividend";
            // 
            // divmem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listdiv);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateend);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datestart);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "divmem";
            this.Text = "divmem";
            this.Load += new System.EventHandler(this.divmem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datestart;
        private System.Windows.Forms.ListView listdiv;
        private System.Windows.Forms.ColumnHeader num;
        private System.Windows.Forms.ColumnHeader pdate;
        private System.Windows.Forms.ColumnHeader pstart;
        private System.Windows.Forms.ColumnHeader pend;
        private System.Windows.Forms.ColumnHeader ppro;
        private System.Windows.Forms.ColumnHeader ppay;
        private System.Windows.Forms.ColumnHeader em;
        private System.Windows.Forms.ColumnHeader mid;
        private System.Windows.Forms.Label label1;
    }
}