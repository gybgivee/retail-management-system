namespace $safeprojectname$
{
    partial class databill
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
            this.listbill = new System.Windows.Forms.ListView();
            this.bcode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ball = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bpay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.emid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(798, 110);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(105, 31);
            this.btn_search.TabIndex = 95;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(456, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 94;
            this.label8.Text = "Untill:";
            // 
            // dateend
            // 
            this.dateend.CustomFormat = "yyyy-MM-dd";
            this.dateend.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateend.Location = new System.Drawing.Point(572, 110);
            this.dateend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateend.Name = "dateend";
            this.dateend.Size = new System.Drawing.Size(178, 22);
            this.dateend.TabIndex = 93;
            this.dateend.ValueChanged += new System.EventHandler(this.dateend_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 92;
            this.label4.Text = "From:";
            // 
            // datestart
            // 
            this.datestart.CustomFormat = "yyyy-MM-dd";
            this.datestart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datestart.Location = new System.Drawing.Point(235, 110);
            this.datestart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datestart.Name = "datestart";
            this.datestart.Size = new System.Drawing.Size(178, 22);
            this.datestart.TabIndex = 91;
            this.datestart.ValueChanged += new System.EventHandler(this.datestart_ValueChanged);
            // 
            // listbill
            // 
            this.listbill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.bcode,
            this.bdate,
            this.ball,
            this.bpay,
            this.emid,
            this.mid});
            this.listbill.HideSelection = false;
            this.listbill.Location = new System.Drawing.Point(74, 191);
            this.listbill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listbill.Name = "listbill";
            this.listbill.Size = new System.Drawing.Size(891, 240);
            this.listbill.TabIndex = 96;
            this.listbill.UseCompatibleStateImageBehavior = false;
            this.listbill.View = System.Windows.Forms.View.Details;
            this.listbill.SelectedIndexChanged += new System.EventHandler(this.listbill_SelectedIndexChanged);
            // 
            // bcode
            // 
            this.bcode.Text = "Receipt No";
            this.bcode.Width = 99;
            // 
            // bdate
            // 
            this.bdate.Text = "Reciept Date";
            this.bdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bdate.Width = 199;
            // 
            // ball
            // 
            this.ball.Text = "Amount";
            this.ball.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ball.Width = 192;
            // 
            // bpay
            // 
            this.bpay.Text = "Total";
            this.bpay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bpay.Width = 126;
            // 
            // emid
            // 
            this.emid.Text = "Employee";
            this.emid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.emid.Width = 122;
            // 
            // mid
            // 
            this.mid.Text = "Member";
            this.mid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mid.Width = 146;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(429, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 97;
            this.label1.Text = "Receipt Search ";
            // 
            // databill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 546);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listbill);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateend);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datestart);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "databill";
            this.Text = "databill";
            this.Load += new System.EventHandler(this.databill_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datestart;
        private System.Windows.Forms.ListView listbill;
        private System.Windows.Forms.ColumnHeader bcode;
        private System.Windows.Forms.ColumnHeader bdate;
        private System.Windows.Forms.ColumnHeader ball;
        private System.Windows.Forms.ColumnHeader bpay;
        private System.Windows.Forms.ColumnHeader emid;
        private System.Windows.Forms.ColumnHeader mid;
        private System.Windows.Forms.Label label1;
    }
}