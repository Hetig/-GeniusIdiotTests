using System;
using System.Collections.Generic;
using ClassLibrary;

namespace GeniusIdiotConsoleApp
{

    internal class Program
    {
        static void Main()
        {

            while (true)
            {               
                Console.WriteLine("Введите имя пользователя");
                
                var user = new User(Console.ReadLine());
                var game = new Game(user);
              

                while (!game.End())
                {    
                    var currentQuestion = game.GetNextQuestion();
                    Console.WriteLine($"{game.GetQuestionNumberText()}: {currentQuestion.Text}");                   

                    var correctUserAnswer = GetCorrectDigitInput();
                    game.AcceptAnswer(correctUserAnswer);
                }

                Console.WriteLine($"Количество правильных ответов: {user.CountRightAnswers}");
                Console.WriteLine($"{game.CalculateDiagnosis()}");

                var userChoiceForWatchStats = GetUserChoiceYesOrNo("Хотите посмотреть статистику прохождения тестов? Введите Да или Нет.");
                if (userChoiceForWatchStats)
                { ShowUserResults(); }

                var userChoiceForAddQuestion = GetUserChoiceYesOrNo("Хотите добавить новый вопрос? Введите Да или Нет.");
                if (userChoiceForAddQuestion)
                { AddNewQuestion(); }

                var userChoiceForDeleteQuestion = GetUserChoiceYesOrNo("Хотите удалить вопрос? Введите Да или Нет.");
                if (userChoiceForDeleteQuestion)
                { DeleteQuestion(); }

                var userChoiceForRepeatTest = GetUserChoiceYesOrNo("Хотите начать тест сначала? Введите Да или Нет.");
                if (userChoiceForRepeatTest == false)
                { break; }

            }

            static void ShowUserResults()
            {
                Console.WriteLine("{0,-10}{1,10}{2,10}", "Имя", "Правильных ответов", "Диагноз");
                var result = UsersResultStorage.GetUserResults();
                foreach (User user in result)
                {
                    Console.WriteLine("{0,-10}{1,9}{2,18}", user.Name, user.CountRightAnswers, user.Diagnosis);
                }
            }           

            static bool GetUserChoiceYesOrNo(string value)
            {
                Console.WriteLine(value);
                var userChoise = Console.ReadLine().ToLower();

                if (userChoise == "да")
                { return true; }
                else if (userChoise == "нет")
                { return false; }

                while (true)
                {
                    Console.WriteLine("Введите Да или Нет.");
                    userChoise = Console.ReadLine().ToLower();

                    if (userChoise == "да")
                    { return true; }
                    else if (userChoise == "нет")
                    { return false; }
                }
            }

            static int GetCorrectDigitInput()
            {
                var parseResult = InputValidator.TryParseNumber(Console.ReadLine(), out int number, out string errorName);
                Console.WriteLine(errorName);
                while (true)
                {
                    if (parseResult)
                    {
                        return number;
                    }
                    else
                    {
                        parseResult = InputValidator.TryParseNumber(Console.ReadLine(), out number, out errorName);
                        Console.WriteLine(errorName);
                    }
                }
            }

            static void AddNewQuestion()
            {
                Console.WriteLine("Введите вопрос, который вы хотите добавить.");
                string text = Console.ReadLine();
                Console.WriteLine("Введите ответ на этот вопрос.");
                int answer = GetCorrectDigitInput();

                Question newQuestion = new Question(text, answer);

                QuestionsStorage.Add(newQuestion);

                Console.WriteLine("Вопрос успешно добавлен.");
            }

            static void DeleteQuestion()
            {
                Console.WriteLine("Выберите вопрос который хотите удалить и введите его номер.");
                var questions = QuestionsStorage.GetAll();
                int i = 1;
                foreach (var question in questions)
                {
                    Console.WriteLine($"Вопрос № {i}: {question.Text}");
                    i++;
                }
                var deleteQuestionNumber = GetCorrectDigitInput();
                while (deleteQuestionNumber < 1 || deleteQuestionNumber > questions.Count)
                {
                    Console.WriteLine($"Введите число от 1 до {questions.Count}!");
                    deleteQuestionNumber = GetCorrectDigitInput();
                }
                var deleteQuestionIndex = deleteQuestionNumber - 1;
                QuestionsStorage.Delete(deleteQuestionIndex);

                Console.WriteLine("Вопрос успешно удален.");
            }
        }
    }
}
