namespace GeniyIdiotWindowsFormsApp
{
    partial class DeleteQuestionForm
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
            this.chooseDeleteLabel = new System.Windows.Forms.Label();
            this.deleteQuestionButton = new System.Windows.Forms.Button();
            this.questionsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // chooseDeleteLabel
            // 
            this.chooseDeleteLabel.AutoSize = true;
            this.chooseDeleteLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseDeleteLabel.Location = new System.Drawing.Point(62, 20);
            this.chooseDeleteLabel.Name = "chooseDeleteLabel";
            this.chooseDeleteLabel.Size = new System.Drawing.Size(339, 19);
            this.chooseDeleteLabel.TabIndex = 0;
            this.chooseDeleteLabel.Text = "Выберите вопрос, который хотите удалить";
            // 
            // deleteQuestionButton
            // 
            this.deleteQuestionButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteQuestionButton.Location = new System.Drawing.Point(504, 12);
            this.deleteQuestionButton.Name = "deleteQuestionButton";
            this.deleteQuestionButton.Size = new System.Drawing.Size(87, 46);
            this.deleteQuestionButton.TabIndex = 2;
            this.deleteQuestionButton.Text = "Удалить";
            this.deleteQuestionButton.UseVisualStyleBackColor = true;
            this.deleteQuestionButton.Click += new System.EventHandler(this.deleteQuestionButton_Click);
            // 
            // questionsListBox
            // 
            this.questionsListBox.FormattingEnabled = true;
            this.questionsListBox.ItemHeight = 16;
            this.questionsListBox.Location = new System.Drawing.Point(35, 64);
            this.questionsListBox.Name = "questionsListBox";
            this.questionsListBox.Size = new System.Drawing.Size(544, 372);
            this.questionsListBox.TabIndex = 3;
            
            // 
            // DeleteQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 450);
            this.Controls.Add(this.questionsListBox);
            this.Controls.Add(this.deleteQuestionButton);
            this.Controls.Add(this.chooseDeleteLabel);
            this.Name = "DeleteQuestionForm";
            this.Text = "DeleteQuestionForm";
            this.Load += new System.EventHandler(this.DeleteQuestionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chooseDeleteLabel;
        private System.Windows.Forms.Button deleteQuestionButton;
        private System.Windows.Forms.ListBox questionsListBox;
    }
}