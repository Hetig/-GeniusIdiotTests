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
    public partial class MainForm : Form
    {
        Game game;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {            
            var user = new User(StartForm.UserName);
            game = new Game(user);
           
            ShowNextQuestion();
        }

        private void ShowNextQuestion()
        {
            var currentQuestion = game.GetNextQuestion();
            questionNumberLabel.Text = game.GetQuestionNumberText();
            questionTextLabel.Text = currentQuestion.Text;            
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            var parsedResult = InputValidator.TryParseNumber(userAnswerTextBox.Text, out int userAnswer, out string errorName);

            if (!parsedResult)
            {
                MessageBox.Show(errorName);
                userAnswerTextBox.Clear();
            }
            else
            {
                game.AcceptAnswer(userAnswer);
                userAnswerTextBox.Clear();

                if (game.End())
                {
                    var testResult = game.CalculateDiagnosis();
                    MessageBox.Show(testResult);
                }
                else
                {
                    ShowNextQuestion();
                }
            }
        }       

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void showStatistcsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var userStatistics = new UserStatisticsForm();
            userStatistics.ShowDialog();
        }

        private void addQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addQuestion = new AddQuestionForm();
            addQuestion.ShowDialog();           
        }

        private void deleteQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var deleteQuestion = new DeleteQuestionForm();
            deleteQuestion.Show();           
        }
    }
}
