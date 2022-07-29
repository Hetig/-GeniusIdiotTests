namespace GeniyIdiotWindowsFormsApp
{
    partial class UserStatisticsForm
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
            this.UserStatsDataGridView = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountRightAnswersColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiagnosisColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.UserStatsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UserStatsDataGridView
            // 
            this.UserStatsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserStatsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.CountRightAnswersColumn,
            this.DiagnosisColumn});
            this.UserStatsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.UserStatsDataGridView.Name = "UserStatsDataGridView";
            this.UserStatsDataGridView.RowHeadersWidth = 51;
            this.UserStatsDataGridView.RowTemplate.Height = 24;
            this.UserStatsDataGridView.Size = new System.Drawing.Size(558, 417);
            this.UserStatsDataGridView.TabIndex = 0;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Имя";
            this.NameColumn.MinimumWidth = 6;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.Width = 125;
            // 
            // CountRightAnswersColumn
            // 
            this.CountRightAnswersColumn.HeaderText = "Правильных ответов";
            this.CountRightAnswersColumn.MinimumWidth = 6;
            this.CountRightAnswersColumn.Name = "CountRightAnswersColumn";
            this.CountRightAnswersColumn.Width = 125;
            // 
            // DiagnosisColumn
            // 
            this.DiagnosisColumn.HeaderText = "Диагноз";
            this.DiagnosisColumn.MinimumWidth = 6;
            this.DiagnosisColumn.Name = "DiagnosisColumn";
            this.DiagnosisColumn.Width = 125;
            // 
            // UserStatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 441);
            this.Controls.Add(this.UserStatsDataGridView);
            this.Name = "UserStatisticsForm";
            this.Text = "UserStatisticsForm";
            this.Load += new System.EventHandler(this.UserStatisticsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserStatsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView UserStatsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountRightAnswersColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiagnosisColumn;
    }
}