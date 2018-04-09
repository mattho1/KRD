namespace KRDLab1
{
    partial class ShowPackages
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
            this.dataGridViewDataAboutPackagesCustomer = new System.Windows.Forms.DataGridView();
            this.ColumnNumberPackage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataAboutPackagesCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDataAboutPackagesCustomer
            // 
            this.dataGridViewDataAboutPackagesCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataAboutPackagesCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumberPackage,
            this.ColumnStatus,
            this.ColumnHour});
            this.dataGridViewDataAboutPackagesCustomer.Location = new System.Drawing.Point(43, 59);
            this.dataGridViewDataAboutPackagesCustomer.Name = "dataGridViewDataAboutPackagesCustomer";
            this.dataGridViewDataAboutPackagesCustomer.RowTemplate.Height = 24;
            this.dataGridViewDataAboutPackagesCustomer.Size = new System.Drawing.Size(543, 353);
            this.dataGridViewDataAboutPackagesCustomer.TabIndex = 0;
            // 
            // ColumnNumberPackage
            // 
            this.ColumnNumberPackage.HeaderText = "Nr paczki";
            this.ColumnNumberPackage.Name = "ColumnNumberPackage";
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.HeaderText = "Status";
            this.ColumnStatus.Name = "ColumnStatus";
            // 
            // ColumnHour
            // 
            this.ColumnHour.HeaderText = "Godzina";
            this.ColumnHour.Name = "ColumnHour";
            this.ColumnHour.Width = 170;
            // 
            // ShowPackages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 473);
            this.Controls.Add(this.dataGridViewDataAboutPackagesCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ShowPackages";
            this.Text = "ShowPackages";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataAboutPackagesCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDataAboutPackagesCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumberPackage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHour;
    }
}