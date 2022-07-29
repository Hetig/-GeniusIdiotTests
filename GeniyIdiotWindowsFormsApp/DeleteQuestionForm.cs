using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeniyIdiotWindowsFormsApp
{
    public partial class DeleteQuestionForm : Form
    {
        public DeleteQuestionForm()
        {
            InitializeComponent();
        }

        private void DeleteQuestionForm_Load(object sender, EventArgs e)
        {
            var questions = QuestionsStorage.GetAll();
            foreach (var question in questions)
            {
                questionsListBox.Items.Add(question.Text);
            }
        }

        private void deleteQuestionButton_Click(object sender, EventArgs e)
        {
            if (this.questionsListBox.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите вопрос!");
            }
            else
            {
                QuestionsStorage.Delete(questionsListBox.SelectedIndex);
                MessageBox.Show("Вопрос успешно удален");
                this.Close();
                Application.Restart();
            }
        }
    }
}
