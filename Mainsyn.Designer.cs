namespace $safeprojectname$
{
    partial class Mainsyn
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(350, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Member and Employee Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_dataend);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(340, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(350, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sales";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_datap);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(340, 457);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(350, 41);
            this.button3.TabIndex = 2;
            this.button3.Text = "Stock Share Yearly Summary";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_div);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_logout.Location = new System.Drawing.Point(864, 34);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(176, 53);
            this.btn_logout.TabIndex = 8;
            this.btn_logout.Text = "Exit";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // Mainsyn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 717);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Mainsyn";
            this.Text = "Mainsyn";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_logout;
    }
}