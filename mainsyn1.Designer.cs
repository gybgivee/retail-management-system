namespace $safeprojectname$
{
    partial class mainsyn1
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
            this.buttonmem = new System.Windows.Forms.Button();
            this.buttonem = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonmem
            // 
            this.buttonmem.Location = new System.Drawing.Point(368, 340);
            this.buttonmem.Name = "buttonmem";
            this.buttonmem.Size = new System.Drawing.Size(350, 41);
            this.buttonmem.TabIndex = 3;
            this.buttonmem.Text = "Member Data";
            this.buttonmem.UseVisualStyleBackColor = true;
            this.buttonmem.Click += new System.EventHandler(this.btn_mem);
            // 
            // buttonem
            // 
            this.buttonem.Location = new System.Drawing.Point(368, 157);
            this.buttonem.Name = "buttonem";
            this.buttonem.Size = new System.Drawing.Size(350, 41);
            this.buttonem.TabIndex = 2;
            this.buttonem.Text = "Employee and Supervisor Data";
            this.buttonem.UseVisualStyleBackColor = true;
            this.buttonem.Click += new System.EventHandler(this.btn_em);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.LightCoral;
            this.btn_back.Location = new System.Drawing.Point(841, 56);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(148, 43);
            this.btn_back.TabIndex = 112;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // mainsyn1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 666);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.buttonmem);
            this.Controls.Add(this.buttonem);
            this.Name = "mainsyn1";
            this.Text = "mainsyn2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonmem;
        private System.Windows.Forms.Button buttonem;
        private System.Windows.Forms.Button btn_back;
    }
}