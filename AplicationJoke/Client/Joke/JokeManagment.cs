using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationJoke.Client.Joke
{
    public static class JokeManagment
    {
        
        public static void JokeMenu(CurrentUser _currentUser)
        {
            Console.WriteLine("1.Pokaż kategorie żartów");
            Console.WriteLine("2.Dodaj nowy żart");
            string input = Console.ReadLine();
            if (!InputMethods.InputValidNumber(input,2))
            {
                Console.WriteLine("Wprowadzona liczba nieprawidłowa");
                return;
            }
            if (string.Equals(input,"1"))
            {
                //Implamentation
            }
            if (string.Equals(input,"2")&&_currentUser.LevelOfAccess.Equals("Admin"))
            {
                //Add new joke
            }
        }
    }
}
