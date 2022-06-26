namespace $safeprojectname$
{
    partial class mainem1
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(433, 259);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(230, 48);
            this.button3.TabIndex = 5;
            this.button3.Text = "Order";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(433, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "Product Registration";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(433, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "Supplier Registration";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(433, 372);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(230, 48);
            this.button4.TabIndex = 6;
            this.button4.Text = "Recieve Order";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(433, 482);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(230, 55);
            this.button5.TabIndex = 7;
            this.button5.Text = "Expenses Summary";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.LightCoral;
            this.btn_back.Location = new System.Drawing.Point(937, 38);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(148, 43);
            this.btn_back.TabIndex = 113;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // mainem1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 700);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "mainem1";
            this.Text = "mainem1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_back;
    }
}