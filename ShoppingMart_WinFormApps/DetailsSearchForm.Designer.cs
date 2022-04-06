namespace ShoppingMart_WinFormApps
{
    partial class DetailsSearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailsSearchForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewBothTableDataShow = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBothTableDataShow)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(879, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewBothTableDataShow
            // 
            this.dataGridViewBothTableDataShow.AllowUserToAddRows = false;
            this.dataGridViewBothTableDataShow.AllowUserToDeleteRows = false;
            this.dataGridViewBothTableDataShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBothTableDataShow.Location = new System.Drawing.Point(30, 290);
            this.dataGridViewBothTableDataShow.Name = "dataGridViewBothTableDataShow";
            this.dataGridViewBothTableDataShow.ReadOnly = true;
            this.dataGridViewBothTableDataShow.RowHeadersWidth = 51;
            this.dataGridViewBothTableDataShow.RowTemplate.Height = 24;
            this.dataGridViewBothTableDataShow.Size = new System.Drawing.Size(853, 441);
            this.dataGridViewBothTableDataShow.TabIndex = 13;
            // 
            // DetailsSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 750);
            this.Controls.Add(this.dataGridViewBothTableDataShow);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DetailsSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailsSearchForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBothTableDataShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewBothTableDataShow;
    }
}