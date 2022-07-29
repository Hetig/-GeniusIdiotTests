namespace GeniyIdiotWindowsFormsApp
{
    partial class StartForm
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
            this.startOkButton = new System.Windows.Forms.Button();
            this.startLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // startOkButton
            // 
            this.startOkButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.startOkButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startOkButton.Location = new System.Drawing.Point(525, 134);
            this.startOkButton.Name = "startOkButton";
            this.startOkButton.Size = new System.Drawing.Size(75, 45);
            this.startOkButton.TabIndex = 0;
            this.startOkButton.Text = "OK";
            this.startOkButton.UseVisualStyleBackColor = false;
            this.startOkButton.Click += new System.EventHandler(this.StartOkButton_Click);
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.startLabel.Location = new System.Drawing.Point(163, 72);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(355, 34);
            this.startLabel.TabIndex = 1;
            this.startLabel.Text = "Введите имя пользователя";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(169, 145);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(349, 22);
            this.userNameTextBox.TabIndex = 2;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.startOkButton);
            this.Name = "StartForm";
            this.Text = "Гений Идиот";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startOkButton;
        private System.Windows.Forms.Label startLabel;
        public System.Windows.Forms.TextBox userNameTextBox;
    }
}