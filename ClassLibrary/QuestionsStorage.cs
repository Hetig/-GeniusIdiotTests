using System.Collections.Generic;
using System.IO;
using System.Text;
using System;
using Newtonsoft.Json;

namespace ClassLibrary
{
    public class QuestionsStorage
    {
        public static string fileName = @"questions.json";
        public static List<Question> GetAll()
        {
            var questions = new List<Question>();

            if (!FileProvider.Exist(fileName))
            {
                questions = GetStandartQuestions();
                Save(questions);
            }
            else
            {
                var value = FileProvider.GetValue(fileName);
                questions = JsonConvert.DeserializeObject<List<Question>>(value);  
            }

            return questions;
        }       

        public static void Save(List<Question> questions)
        {
            var jsonData = JsonConvert.SerializeObject(questions, Formatting.Indented);
            FileProvider.Replace(fileName, jsonData);
        }

        public static void Add(Question newQuestion)
        {
            var questions = GetAll();
            questions.Add(newQuestion);
            Save(questions);
        }

        public static void Delete(int deleteQuestionIndex)
        {
            var questions = GetAll();
            questions.Remove(questions[deleteQuestionIndex]);            
            Save(questions);
        }

        static List<Question> GetStandartQuestions()
        {
            var questions = new List<Question>();

            questions.Add(new Question("Сколько будет два плюс два умноженное на два?", 6));
            questions.Add(new Question("Бревно нужно распилить на 10 частей, сколько нужно сделать распилов?", 9));
            questions.Add(new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25));
            questions.Add(new Question("Укол делают каждые пол часа, сколько нужно минут для трех уколов?", 60));
            questions.Add(new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", 2));

            Save(questions);
            return questions;
        }
    }
}
