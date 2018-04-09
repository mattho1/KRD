namespace KRDLab1
{
    partial class ChangeStatus
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
            this.groupBoxSelectionOfStatus = new System.Windows.Forms.GroupBox();
            this.radioButtonInSystem = new System.Windows.Forms.RadioButton();
            this.radioButtonInWarehouse = new System.Windows.Forms.RadioButton();
            this.radioButtonOnTheWay = new System.Windows.Forms.RadioButton();
            this.radioButtonDelivered = new System.Windows.Forms.RadioButton();
            this.buttonChange = new System.Windows.Forms.Button();
            this.groupBoxSelectionOfStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSelectionOfStatus
            // 
            this.groupBoxSelectionOfStatus.Controls.Add(this.radioButtonInSystem);
            this.groupBoxSelectionOfStatus.Controls.Add(this.radioButtonInWarehouse);
            this.groupBoxSelectionOfStatus.Controls.Add(this.radioButtonOnTheWay);
            this.groupBoxSelectionOfStatus.Controls.Add(this.radioButtonDelivered);
            this.groupBoxSelectionOfStatus.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSelectionOfStatus.Name = "groupBoxSelectionOfStatus";
            this.groupBoxSelectionOfStatus.Size = new System.Drawing.Size(434, 230);
            this.groupBoxSelectionOfStatus.TabIndex = 0;
            this.groupBoxSelectionOfStatus.TabStop = false;
            // 
            // radioButtonInSystem
            // 
            this.radioButtonInSystem.AutoSize = true;
            this.radioButtonInSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonInSystem.Location = new System.Drawing.Point(24, 178);
            this.radioButtonInSystem.Name = "radioButtonInSystem";
            this.radioButtonInSystem.Size = new System.Drawing.Size(139, 29);
            this.radioButtonInSystem.TabIndex = 3;
            this.radioButtonInSystem.TabStop = true;
            this.radioButtonInSystem.Text = "w systemie";
            this.radioButtonInSystem.UseVisualStyleBackColor = true;
            this.radioButtonInSystem.CheckedChanged += new System.EventHandler(this.radioButtonInSystem_CheckedChanged);
            // 
            // radioButtonInWarehouse
            // 
            this.radioButtonInWarehouse.AutoSize = true;
            this.radioButtonInWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonInWarehouse.Location = new System.Drawing.Point(24, 131);
            this.radioButtonInWarehouse.Name = "radioButtonInWarehouse";
            this.radioButtonInWarehouse.Size = new System.Drawing.Size(158, 29);
            this.radioButtonInWarehouse.TabIndex = 2;
            this.radioButtonInWarehouse.TabStop = true;
            this.radioButtonInWarehouse.Text = "w magazynie";
            this.radioButtonInWarehouse.UseVisualStyleBackColor = true;
            this.radioButtonInWarehouse.CheckedChanged += new System.EventHandler(this.radioButtonInWarehouse_CheckedChanged);
            // 
            // radioButtonOnTheWay
            // 
            this.radioButtonOnTheWay.AutoSize = true;
            this.radioButtonOnTheWay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonOnTheWay.Location = new System.Drawing.Point(24, 82);
            this.radioButtonOnTheWay.Name = "radioButtonOnTheWay";
            this.radioButtonOnTheWay.Size = new System.Drawing.Size(120, 29);
            this.radioButtonOnTheWay.TabIndex = 1;
            this.radioButtonOnTheWay.TabStop = true;
            this.radioButtonOnTheWay.Text = "w drodze";
            this.radioButtonOnTheWay.UseVisualStyleBackColor = true;
            this.radioButtonOnTheWay.CheckedChanged += new System.EventHandler(this.radioButtonOnTheWay_CheckedChanged);
            // 
            // radioButtonDelivered
            // 
            this.radioButtonDelivered.AutoSize = true;
            this.radioButtonDelivered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonDelivered.Location = new System.Drawing.Point(24, 33);
            this.radioButtonDelivered.Name = "radioButtonDelivered";
            this.radioButtonDelivered.Size = new System.Drawing.Size(151, 29);
            this.radioButtonDelivered.TabIndex = 0;
            this.radioButtonDelivered.TabStop = true;
            this.radioButtonDelivered.Text = "dostarczono";
            this.radioButtonDelivered.UseVisualStyleBackColor = true;
            this.radioButtonDelivered.CheckedChanged += new System.EventHandler(this.radioButtonDelivered_CheckedChanged);
            // 
            // buttonChange
            // 
            this.buttonChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonChange.Location = new System.Drawing.Point(36, 263);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(151, 35);
            this.buttonChange.TabIndex = 1;
            this.buttonChange.Text = "Zmień";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // ChangeStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 314);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.groupBoxSelectionOfStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChangeStatus";
            this.Text = "ChangeStatus";
            this.groupBoxSelectionOfStatus.ResumeLayout(false);
            this.groupBoxSelectionOfStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSelectionOfStatus;
        private System.Windows.Forms.RadioButton radioButtonInSystem;
        private System.Windows.Forms.RadioButton radioButtonInWarehouse;
        private System.Windows.Forms.RadioButton radioButtonOnTheWay;
        private System.Windows.Forms.RadioButton radioButtonDelivered;
        private System.Windows.Forms.Button buttonChange;
    }
}