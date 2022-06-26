namespace $safeprojectname$
{
    partial class mainem3
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
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "Member Registration";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(455, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(228, 49);
            this.button2.TabIndex = 6;
            this.button2.Text = "Member Details";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.LightCoral;
            this.btn_back.Location = new System.Drawing.Point(964, 66);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(148, 43);
            this.btn_back.TabIndex = 114;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // mainem3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 721);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "mainem3";
            this.Text = "mainem3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_back;
    }
}