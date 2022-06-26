namespace $safeprojectname$
{
    partial class addsup
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
            this.label7 = new System.Windows.Forms.Label();
            this.txt_contact = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.RegisOK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(304, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 25);
            this.label7.TabIndex = 86;
            this.label7.Text = "Address:";
            // 
            // txt_contact
            // 
            this.txt_contact.Location = new System.Drawing.Point(455, 354);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(338, 140);
            this.txt_contact.TabIndex = 85;
            this.txt_contact.Text = "";
            this.txt_contact.TextChanged += new System.EventHandler(this.txt_contact_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(288, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 25);
            this.label5.TabIndex = 84;
            this.label5.Text = "Supplier Details:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(455, 242);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(271, 26);
            this.txt_name.TabIndex = 83;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // RegisOK
            // 
            this.RegisOK.Location = new System.Drawing.Point(506, 579);
            this.RegisOK.Name = "RegisOK";
            this.RegisOK.Size = new System.Drawing.Size(135, 49);
            this.RegisOK.TabIndex = 80;
            this.RegisOK.Text = "Save";
            this.RegisOK.UseVisualStyleBackColor = true;
            this.RegisOK.Click += new System.EventHandler(this.RegisOK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(400, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 36);
            this.label3.TabIndex = 79;
            this.label3.Text = "Supplier Registration";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(455, 152);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(271, 26);
            this.txt_id.TabIndex = 74;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(279, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 73;
            this.label2.Text = "Supplier ID:";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.LightCoral;
            this.btn_back.Location = new System.Drawing.Point(858, 42);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(148, 43);
            this.btn_back.TabIndex = 111;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // addsup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 700);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_contact);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.RegisOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label2);
            this.Name = "addsup";
            this.Text = "addproductcs";
            this.Load += new System.EventHandler(this.addsup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txt_contact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button RegisOK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_back;
    }
}