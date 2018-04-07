namespace KRDLab1
{
    partial class Menu
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
            this.buttonManageUsers = new System.Windows.Forms.Button();
            this.buttonManagePackages = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonManageUsers
            // 
            this.buttonManageUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonManageUsers.Location = new System.Drawing.Point(189, 162);
            this.buttonManageUsers.Name = "buttonManageUsers";
            this.buttonManageUsers.Size = new System.Drawing.Size(265, 50);
            this.buttonManageUsers.TabIndex = 0;
            this.buttonManageUsers.Text = "Zarządzaj użytkownikami";
            this.buttonManageUsers.UseVisualStyleBackColor = true;
            this.buttonManageUsers.Click += new System.EventHandler(this.buttonManageUsers_Click);
            // 
            // buttonManagePackages
            // 
            this.buttonManagePackages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonManagePackages.Location = new System.Drawing.Point(189, 254);
            this.buttonManagePackages.Name = "buttonManagePackages";
            this.buttonManagePackages.Size = new System.Drawing.Size(265, 50);
            this.buttonManagePackages.TabIndex = 1;
            this.buttonManagePackages.Text = "Zarządzaj paczkami";
            this.buttonManagePackages.UseVisualStyleBackColor = true;
            this.buttonManagePackages.Click += new System.EventHandler(this.buttonManagePackages_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLogOut.Location = new System.Drawing.Point(12, 12);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(117, 56);
            this.buttonLogOut.TabIndex = 2;
            this.buttonLogOut.Text = "Wyloguj";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 446);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonManagePackages);
            this.Controls.Add(this.buttonManageUsers);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonManageUsers;
        private System.Windows.Forms.Button buttonManagePackages;
        private System.Windows.Forms.Button buttonLogOut;
    }
}