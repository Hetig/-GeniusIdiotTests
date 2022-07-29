using GeniyIdiotWindowsFormsApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{     
    public class Game
    {
        List<Question> questions;
        Question currentQuestion;
        User user;
        int countQuestions;
        int questionNumber = 0;

        public Game(User user)
        {
            this.user = user;   
            questions = QuestionsStorage.GetAll();
            countQuestions = questions.Count;
        }

        public Question GetNextQuestion()
        {
            var random = new Random();
            var randomIndex = random.Next(0, questions.Count);

            questionNumber++;

            currentQuestion = questions[randomIndex];           
            return currentQuestion;
        }

        public void AcceptAnswer(int userAnswer)
        {
            if (userAnswer == currentQuestion.Answer)
            {
                user.AcceptRightAnswer();
            }

            questions.Remove(currentQuestion);
        }

        public string GetQuestionNumberText()
        {
            return $"Вопрос № {questionNumber}";
        }

        public bool End()
        {
            return questions.Count == 0;
        }

        public string CalculateDiagnosis()
        {
            user.Diagnosis = DiagnosisCalculator.Calculate(countQuestions, user);
            string testResult = $"{user.Name}! Ваш диагноз {user.Diagnosis}";

            UsersResultStorage.Save(user);
            return testResult;
        }
    }
}
