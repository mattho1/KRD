namespace KRDLab1
{
    partial class ManagePackagesWindow
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnNumberPackage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonChangeStatus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumberPackage,
            this.ColumnStatus,
            this.ColumnHour});
            this.dataGridView1.Location = new System.Drawing.Point(58, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(643, 280);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnNumberPackage
            // 
            this.ColumnNumberPackage.HeaderText = "Nr paczki";
            this.ColumnNumberPackage.Name = "ColumnNumberPackage";
            this.ColumnNumberPackage.Width = 200;
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.HeaderText = "Status";
            this.ColumnStatus.Name = "ColumnStatus";
            this.ColumnStatus.Width = 200;
            // 
            // ColumnHour
            // 
            this.ColumnHour.HeaderText = "Godzina";
            this.ColumnHour.Name = "ColumnHour";
            this.ColumnHour.Width = 200;
            // 
            // buttonChangeStatus
            // 
            this.buttonChangeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonChangeStatus.Location = new System.Drawing.Point(58, 47);
            this.buttonChangeStatus.Name = "buttonChangeStatus";
            this.buttonChangeStatus.Size = new System.Drawing.Size(104, 45);
            this.buttonChangeStatus.TabIndex = 1;
            this.buttonChangeStatus.Text = "Zmień status";
            this.buttonChangeStatus.UseVisualStyleBackColor = true;
            this.buttonChangeStatus.Click += new System.EventHandler(this.buttonChangeStatus_Click);
            // 
            // ManagePackagesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 505);
            this.Controls.Add(this.buttonChangeStatus);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManagePackagesWindow";
            this.Text = "ManagePackagesWindow";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumberPackage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHour;
        private System.Windows.Forms.Button buttonChangeStatus;
    }
}