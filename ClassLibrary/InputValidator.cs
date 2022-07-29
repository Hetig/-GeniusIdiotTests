using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class InputValidator
    {
        public static bool TryParseNumber(string input, out int number, out string errorName)
        {
            try
            { 
                number = Convert.ToInt32(input);
                errorName = "";
                return true;
            }
            catch (FormatException)
            {
                number = 0;
                errorName = "Введите число!"; 
                return false;
            }
            catch (OverflowException)
            {
                number = 0;
                errorName = "Слишком большое число! Ответ должен быть в пределах от -2*10^9 до 2*10^9.";
                return false;
            }
        }
    }
}
