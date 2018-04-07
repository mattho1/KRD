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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagePackagesWindow));
            this.dataGridViewPackages = new System.Windows.Forms.DataGridView();
            this.buttonChangeStatus = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.ColumnNumberPackage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClientSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPackages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPackages
            // 
            this.dataGridViewPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPackages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumberPackage,
            this.ColumnStatus,
            this.ColumnHour,
            this.ColumnClientName,
            this.ColumnClientSurname});
            this.dataGridViewPackages.Location = new System.Drawing.Point(58, 146);
            this.dataGridViewPackages.Name = "dataGridViewPackages";
            this.dataGridViewPackages.RowTemplate.Height = 24;
            this.dataGridViewPackages.Size = new System.Drawing.Size(876, 280);
            this.dataGridViewPackages.TabIndex = 0;
            // 
            // buttonChangeStatus
            // 
            this.buttonChangeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonChangeStatus.Location = new System.Drawing.Point(542, 47);
            this.buttonChangeStatus.Name = "buttonChangeStatus";
            this.buttonChangeStatus.Size = new System.Drawing.Size(150, 45);
            this.buttonChangeStatus.TabIndex = 1;
            this.buttonChangeStatus.Text = "Zmień status";
            this.buttonChangeStatus.UseVisualStyleBackColor = true;
            this.buttonChangeStatus.Click += new System.EventHandler(this.buttonChangeStatus_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdd.Location = new System.Drawing.Point(58, 47);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(150, 45);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRemove.Location = new System.Drawing.Point(784, 47);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(150, 45);
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.Text = "Usuń";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEdit.Location = new System.Drawing.Point(300, 47);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(150, 45);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "Edytuj";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // ColumnNumberPackage
            // 
            this.ColumnNumberPackage.HeaderText = "Nr paczki";
            this.ColumnNumberPackage.Name = "ColumnNumberPackage";
            this.ColumnNumberPackage.Width = 120;
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.HeaderText = "Status";
            this.ColumnStatus.Name = "ColumnStatus";
            this.ColumnStatus.Width = 120;
            // 
            // ColumnHour
            // 
            this.ColumnHour.HeaderText = "Godzina";
            this.ColumnHour.Name = "ColumnHour";
            this.ColumnHour.Width = 160;
            // 
            // ColumnClientName
            // 
            this.ColumnClientName.HeaderText = "Imie klienta";
            this.ColumnClientName.Name = "ColumnClientName";
            this.ColumnClientName.Width = 150;
            // 
            // ColumnClientSurname
            // 
            this.ColumnClientSurname.HeaderText = "Nazwisko klienta";
            this.ColumnClientSurname.Name = "ColumnClientSurname";
            this.ColumnClientSurname.Width = 150;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(58, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(86, 118);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(849, 22);
            this.textBoxSearch.TabIndex = 6;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // ManagePackagesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 505);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonChangeStatus);
            this.Controls.Add(this.dataGridViewPackages);
            this.Name = "ManagePackagesWindow";
            this.Text = "ManagePackagesWindow";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPackages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPackages;
        private System.Windows.Forms.Button buttonChangeStatus;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumberPackage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClientSurname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxSearch;
    }
}