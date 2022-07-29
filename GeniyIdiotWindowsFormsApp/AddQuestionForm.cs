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
    public partial class AddQuestionForm : Form
    {
        public AddQuestionForm()
        {
            InitializeComponent();
        }

        private void addQuestionButton_Click(object sender, EventArgs e)
        {
            var parsedResult = InputValidator.TryParseNumber(addAnswerTextBox.Text, out int answer, out string errorName);
            var nullOrEmptyResult = String.IsNullOrEmpty(addQuestionTextBox.Text);
            if (nullOrEmptyResult)
            {
                MessageBox.Show("Введите вопрос!");
            }
            else if (!parsedResult)
            {
                MessageBox.Show("Ответ это число. " + errorName);
            }
            else
            {
                var newQuestion = new Question(addQuestionTextBox.Text, answer);
                QuestionsStorage.Add(newQuestion);
                MessageBox.Show("Вопрос успешно добавлен");
                this.Close();
                Application.Restart();
            }
        }
    }
}
