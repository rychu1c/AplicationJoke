using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationJoke.Client
{
    public class InputMethods
    {
        public static string GetInput(string conntent)
        {
            while (true)
            {
                Console.WriteLine(conntent);
                string input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    return input;
                }
                
            }
        }
        public static string WhiteSpace(string input)
        {
            
            string exampleTrimmed = String.Concat(input.Where(c => !Char.IsWhiteSpace(c)));
            return exampleTrimmed;
        }
        public static bool InputValidNumber(string input,int numberOfOptions)
        {
            int number;
            bool success = int.TryParse(input, out number);
            if (!success)
            {
                return false;
            }
            if (number > numberOfOptions || number < 1)
            {
                return false;
            }
            return true;
        }
    }
}
