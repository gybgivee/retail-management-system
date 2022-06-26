namespace $safeprojectname$
{
    partial class login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userin = new System.Windows.Forms.TextBox();
            this.passin = new System.Windows.Forms.TextBox();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.loginfirst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "USERNAME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "PASSWORD:";
            // 
            // userin
            // 
            this.userin.Location = new System.Drawing.Point(470, 214);
            this.userin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userin.Name = "userin";
            this.userin.Size = new System.Drawing.Size(184, 22);
            this.userin.TabIndex = 3;
            this.userin.TextChanged += new System.EventHandler(this.userin_TextChanged);
            // 
            // passin
            // 
            this.passin.Location = new System.Drawing.Point(470, 274);
            this.passin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passin.Name = "passin";
            this.passin.PasswordChar = '*';
            this.passin.Size = new System.Drawing.Size(184, 22);
            this.passin.TabIndex = 4;
            // 
            // ButtonOK
            // 
            this.ButtonOK.Location = new System.Drawing.Point(504, 386);
            this.ButtonOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(112, 34);
            this.ButtonOK.TabIndex = 5;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.buttonok);
            // 
            // loginfirst
            // 
            this.loginfirst.AutoSize = true;
            this.loginfirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.loginfirst.Location = new System.Drawing.Point(498, 100);
            this.loginfirst.Name = "loginfirst";
            this.loginfirst.Size = new System.Drawing.Size(99, 31);
            this.loginfirst.TabIndex = 6;
            this.loginfirst.Text = "LOGIN";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 606);
            this.Controls.Add(this.loginfirst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.userin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "login";
            this.Text = "ลงชื่อเข้าสู่ระบบ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userin;
        private System.Windows.Forms.TextBox passin;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Label loginfirst;
    }
}