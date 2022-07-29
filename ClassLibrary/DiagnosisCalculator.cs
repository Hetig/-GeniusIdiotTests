using ClassLibrary;
using System.Collections.Generic;

namespace GeniyIdiotWindowsFormsApp
{
    public class DiagnosisCalculator
    {
        public string Diagnosis;

        public static string Calculate(int countQuestions,User user)
        {
            var oneStepOfDiagnosis = (double)countQuestions / 6;
            var diagnoses = new List<string>();
            diagnoses.Add("Идиот");
            diagnoses.Add("Кретин");
            diagnoses.Add("Дурак");
            diagnoses.Add("Нормальный");
            diagnoses.Add("Талант");
            diagnoses.Add("Гений");

            for (int i = 0; i < 6; i++)
            {
                if (user.CountRightAnswers <= (i + 1) * oneStepOfDiagnosis)
                { 
                    return diagnoses[i]; 
                }
            }
            return "Произошла ошибка! Попробуйте начать тест сначала или обратитесь в поддержку.";
        }
    }
}
