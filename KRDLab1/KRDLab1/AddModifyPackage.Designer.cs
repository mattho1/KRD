namespace KRDLab1
{
    partial class AddModifyPackage
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
            this.labelClient = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelNumberPackage = new System.Windows.Forms.Label();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.buttonAddOrModify = new System.Windows.Forms.Button();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.buttonAddNewClient = new System.Windows.Forms.Button();
            this.numericUpDownNumberPackage = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberPackage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelClient.Location = new System.Drawing.Point(33, 137);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(67, 25);
            this.labelClient.TabIndex = 21;
            this.labelClient.Text = "Klient";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStatus.Location = new System.Drawing.Point(33, 82);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(74, 25);
            this.labelStatus.TabIndex = 19;
            this.labelStatus.Text = "Status";
            // 
            // labelNumberPackage
            // 
            this.labelNumberPackage.AutoSize = true;
            this.labelNumberPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNumberPackage.Location = new System.Drawing.Point(33, 26);
            this.labelNumberPackage.Name = "labelNumberPackage";
            this.labelNumberPackage.Size = new System.Drawing.Size(102, 25);
            this.labelNumberPackage.TabIndex = 18;
            this.labelNumberPackage.Text = "Nr paczki";
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(173, 137);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(441, 33);
            this.comboBoxClient.TabIndex = 17;
            // 
            // buttonAddOrModify
            // 
            this.buttonAddOrModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddOrModify.Location = new System.Drawing.Point(431, 322);
            this.buttonAddOrModify.Name = "buttonAddOrModify";
            this.buttonAddOrModify.Size = new System.Drawing.Size(183, 55);
            this.buttonAddOrModify.TabIndex = 26;
            this.buttonAddOrModify.Text = "Dodaj/Modyfikuj";
            this.buttonAddOrModify.UseVisualStyleBackColor = true;
            this.buttonAddOrModify.Click += new System.EventHandler(this.buttonAddOrModify_Click);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(173, 79);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(204, 33);
            this.comboBoxStatus.TabIndex = 27;
            // 
            // buttonAddNewClient
            // 
            this.buttonAddNewClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddNewClient.Location = new System.Drawing.Point(173, 176);
            this.buttonAddNewClient.Name = "buttonAddNewClient";
            this.buttonAddNewClient.Size = new System.Drawing.Size(441, 35);
            this.buttonAddNewClient.TabIndex = 36;
            this.buttonAddNewClient.Text = "Dodaj nowego klienta";
            this.buttonAddNewClient.UseVisualStyleBackColor = true;
            this.buttonAddNewClient.Click += new System.EventHandler(this.buttonAddNewClient_Click);
            // 
            // numericUpDownNumberPackage
            // 
            this.numericUpDownNumberPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownNumberPackage.Location = new System.Drawing.Point(173, 24);
            this.numericUpDownNumberPackage.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownNumberPackage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumberPackage.Name = "numericUpDownNumberPackage";
            this.numericUpDownNumberPackage.Size = new System.Drawing.Size(129, 30);
            this.numericUpDownNumberPackage.TabIndex = 37;
            this.numericUpDownNumberPackage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddModifyPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 399);
            this.Controls.Add(this.numericUpDownNumberPackage);
            this.Controls.Add(this.buttonAddNewClient);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.buttonAddOrModify);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelNumberPackage);
            this.Controls.Add(this.comboBoxClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddModifyPackage";
            this.Text = "AddModifyPackage";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberPackage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelNumberPackage;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.Button buttonAddOrModify;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Button buttonAddNewClient;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberPackage;
    }
}