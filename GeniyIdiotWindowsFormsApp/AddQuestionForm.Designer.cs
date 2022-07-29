namespace GeniyIdiotWindowsFormsApp
{
    partial class AddQuestionForm
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
            this.addQuestionButton = new System.Windows.Forms.Button();
            this.addQuestionTextBox = new System.Windows.Forms.TextBox();
            this.addAnswerTextBox = new System.Windows.Forms.TextBox();
            this.addQuestionLabel = new System.Windows.Forms.Label();
            this.addAnswerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addQuestionButton
            // 
            this.addQuestionButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addQuestionButton.Location = new System.Drawing.Point(280, 284);
            this.addQuestionButton.Name = "addQuestionButton";
            this.addQuestionButton.Size = new System.Drawing.Size(102, 60);
            this.addQuestionButton.TabIndex = 0;
            this.addQuestionButton.Text = "Добавить";
            this.addQuestionButton.UseVisualStyleBackColor = true;
            this.addQuestionButton.Click += new System.EventHandler(this.addQuestionButton_Click);
            // 
            // addQuestionTextBox
            // 
            this.addQuestionTextBox.Location = new System.Drawing.Point(112, 85);
            this.addQuestionTextBox.Name = "addQuestionTextBox";
            this.addQuestionTextBox.Size = new System.Drawing.Size(434, 22);
            this.addQuestionTextBox.TabIndex = 1;
            // 
            // addAnswerTextBox
            // 
            this.addAnswerTextBox.Location = new System.Drawing.Point(112, 212);
            this.addAnswerTextBox.Name = "addAnswerTextBox";
            this.addAnswerTextBox.Size = new System.Drawing.Size(434, 22);
            this.addAnswerTextBox.TabIndex = 2;
            // 
            // addQuestionLabel
            // 
            this.addQuestionLabel.AutoSize = true;
            this.addQuestionLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addQuestionLabel.Location = new System.Drawing.Point(133, 34);
            this.addQuestionLabel.Name = "addQuestionLabel";
            this.addQuestionLabel.Size = new System.Drawing.Size(392, 23);
            this.addQuestionLabel.TabIndex = 3;
            this.addQuestionLabel.Text = "Введите вопрос, который хотите добавить";
            // 
            // addAnswerLabel
            // 
            this.addAnswerLabel.AutoSize = true;
            this.addAnswerLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addAnswerLabel.Location = new System.Drawing.Point(186, 167);
            this.addAnswerLabel.Name = "addAnswerLabel";
            this.addAnswerLabel.Size = new System.Drawing.Size(275, 23);
            this.addAnswerLabel.TabIndex = 4;
            this.addAnswerLabel.Text = "Введите ответ на этот вопрос";
            // 
            // AddQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 450);
            this.Controls.Add(this.addAnswerLabel);
            this.Controls.Add(this.addQuestionLabel);
            this.Controls.Add(this.addAnswerTextBox);
            this.Controls.Add(this.addQuestionTextBox);
            this.Controls.Add(this.addQuestionButton);
            this.Name = "AddQuestionForm";
            this.Text = "Добавить вопрос";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addQuestionButton;
        private System.Windows.Forms.TextBox addQuestionTextBox;
        private System.Windows.Forms.TextBox addAnswerTextBox;
        private System.Windows.Forms.Label addQuestionLabel;
        private System.Windows.Forms.Label addAnswerLabel;
    }
}