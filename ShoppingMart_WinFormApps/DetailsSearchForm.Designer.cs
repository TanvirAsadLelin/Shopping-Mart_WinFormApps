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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblFisrtDate = new System.Windows.Forms.Label();
            this.textBoxShowFinalCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerFirstDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerSecondDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearchByDateWise = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
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
            this.dataGridViewBothTableDataShow.Location = new System.Drawing.Point(30, 406);
            this.dataGridViewBothTableDataShow.Name = "dataGridViewBothTableDataShow";
            this.dataGridViewBothTableDataShow.ReadOnly = true;
            this.dataGridViewBothTableDataShow.RowHeadersWidth = 51;
            this.dataGridViewBothTableDataShow.RowTemplate.Height = 24;
            this.dataGridViewBothTableDataShow.Size = new System.Drawing.Size(853, 325);
            this.dataGridViewBothTableDataShow.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Search By Invoice";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(29, 231);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(178, 30);
            this.textBoxSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(32, 280);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 42);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblFisrtDate
            // 
            this.lblFisrtDate.AutoSize = true;
            this.lblFisrtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFisrtDate.Location = new System.Drawing.Point(442, 195);
            this.lblFisrtDate.Name = "lblFisrtDate";
            this.lblFisrtDate.Size = new System.Drawing.Size(126, 20);
            this.lblFisrtDate.TabIndex = 16;
            this.lblFisrtDate.Text = "First Date Time";
            // 
            // textBoxShowFinalCost
            // 
            this.textBoxShowFinalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxShowFinalCost.Location = new System.Drawing.Point(158, 346);
            this.textBoxShowFinalCost.Name = "textBoxShowFinalCost";
            this.textBoxShowFinalCost.ReadOnly = true;
            this.textBoxShowFinalCost.Size = new System.Drawing.Size(159, 30);
            this.textBoxShowFinalCost.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(442, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Second Date Time ";
            // 
            // dateTimePickerFirstDate
            // 
            this.dateTimePickerFirstDate.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            this.dateTimePickerFirstDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFirstDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFirstDate.Location = new System.Drawing.Point(446, 220);
            this.dateTimePickerFirstDate.Name = "dateTimePickerFirstDate";
            this.dateTimePickerFirstDate.Size = new System.Drawing.Size(318, 27);
            this.dateTimePickerFirstDate.TabIndex = 18;
            // 
            // dateTimePickerSecondDate
            // 
            this.dateTimePickerSecondDate.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            this.dateTimePickerSecondDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerSecondDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerSecondDate.Location = new System.Drawing.Point(446, 284);
            this.dateTimePickerSecondDate.Name = "dateTimePickerSecondDate";
            this.dateTimePickerSecondDate.Size = new System.Drawing.Size(318, 27);
            this.dateTimePickerSecondDate.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Final cost: ";
            // 
            // btnSearchByDateWise
            // 
            this.btnSearchByDateWise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByDateWise.Location = new System.Drawing.Point(446, 332);
            this.btnSearchByDateWise.Name = "btnSearchByDateWise";
            this.btnSearchByDateWise.Size = new System.Drawing.Size(112, 42);
            this.btnSearchByDateWise.TabIndex = 15;
            this.btnSearchByDateWise.Text = "Search";
            this.btnSearchByDateWise.UseVisualStyleBackColor = true;
            this.btnSearchByDateWise.Click += new System.EventHandler(this.btnSearchByDateWise_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(591, 332);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 42);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // DetailsSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 750);
            this.Controls.Add(this.dateTimePickerSecondDate);
            this.Controls.Add(this.dateTimePickerFirstDate);
            this.Controls.Add(this.textBoxShowFinalCost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFisrtDate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSearchByDateWise);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewBothTableDataShow);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DetailsSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailsSearchForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBothTableDataShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewBothTableDataShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblFisrtDate;
        private System.Windows.Forms.TextBox textBoxShowFinalCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerFirstDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerSecondDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearchByDateWise;
        private System.Windows.Forms.Button btnReset;
    }
}