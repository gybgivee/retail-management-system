namespace $safeprojectname$
{
    partial class supdetail
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
            this.datasupGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datasupGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // datasupGrid
            // 
            this.datasupGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datasupGrid.Location = new System.Drawing.Point(89, 73);
            this.datasupGrid.Name = "datasupGrid";
            this.datasupGrid.RowTemplate.Height = 28;
            this.datasupGrid.Size = new System.Drawing.Size(873, 452);
            this.datasupGrid.TabIndex = 0;
            this.datasupGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datasupgrid_CellContentClick);
            // 
            // supdetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 665);
            this.Controls.Add(this.datasupGrid);
            this.Name = "supdetail";
            this.Text = "ok";
            this.Load += new System.EventHandler(this.supdetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datasupGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datasupGrid;
    }
}