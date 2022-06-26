namespace $safeprojectname$
{
    partial class regismem
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
            this.label11 = new System.Windows.Forms.Label();
            this.Combo_gen = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.RegisOK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label11.Location = new System.Drawing.Point(339, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 20);
            this.label11.TabIndex = 70;
            this.label11.Text = "Gender:";
            // 
            // Combo_gen
            // 
            this.Combo_gen.FormattingEnabled = true;
            this.Combo_gen.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.Combo_gen.Location = new System.Drawing.Point(423, 242);
            this.Combo_gen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Combo_gen.Name = "Combo_gen";
            this.Combo_gen.Size = new System.Drawing.Size(184, 24);
            this.Combo_gen.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(326, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 62;
            this.label5.Text = "Fullname:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(423, 178);
            this.txt_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(241, 22);
            this.txt_name.TabIndex = 61;
            // 
            // RegisOK
            // 
            this.RegisOK.Location = new System.Drawing.Point(472, 435);
            this.RegisOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegisOK.Name = "RegisOK";
            this.RegisOK.Size = new System.Drawing.Size(120, 39);
            this.RegisOK.TabIndex = 58;
            this.RegisOK.Text = "OK";
            this.RegisOK.UseVisualStyleBackColor = true;
            this.RegisOK.Click += new System.EventHandler(this.RegisOK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(436, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 29);
            this.label3.TabIndex = 57;
            this.label3.Text = "Member Registration";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(423, 110);
            this.txt_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(241, 22);
            this.txt_id.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(315, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "Member Id:";
            // 
            // txt_contact
            // 
            this.txt_contact.Location = new System.Drawing.Point(423, 291);
            this.txt_contact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_contact.Multiline = true;
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(320, 98);
            this.txt_contact.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(332, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 72;
            this.label1.Text = "Address:";
            // 
            // regismem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_contact);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Combo_gen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.RegisOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "regismem";
            this.Text = "regismem";
            this.Load += new System.EventHandler(this.regismem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox Combo_gen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button RegisOK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.Label label1;
    }
}