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
            this.SuspendLayout();
            // 
            // buttonManageUsers
            // 
            this.buttonManageUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonManageUsers.Location = new System.Drawing.Point(184, 209);
            this.buttonManageUsers.Name = "buttonManageUsers";
            this.buttonManageUsers.Size = new System.Drawing.Size(265, 50);
            this.buttonManageUsers.TabIndex = 0;
            this.buttonManageUsers.Text = "Zarządzaj użytkownikami";
            this.buttonManageUsers.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 503);
            this.Controls.Add(this.buttonManageUsers);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonManageUsers;
    }
}