using AplicationJoke.Client.Joke;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AplicationJoke.Client
{
    public class MainMenu
    {
        private static CurrentUser _currentUser;
        public static void MainLogic()
        {
            ChooseRegistrationOrLoginIn();
            UserLogedIn();

        }
        private static void ChooseRegistrationOrLoginIn()
        {
            Console.WriteLine("Witaj w aplikacji");
            while (true)
            {
                Console.WriteLine("Wpisz 1 by się zarejestrować.\nWpisz 2 by się zalogować");
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    continue;
                }
                if (input == "1" && Register.RegistrationFormula() == true)
                {
                    Console.WriteLine("Proces Rejestracji");
                }
                if (input == "2")
                {
                    break;
                }
            }
        }
        private static void UserLogedIn()
        {
            _currentUser = Loggin.LogInToSystem();
        }
        private static void MenuAfterLoginIn()
        {
            Console.WriteLine($"Witaj {_currentUser.Login}!");
            while (true)
            {
                Console.WriteLine("1.Zarządzaj Administoracją");
                Console.WriteLine("2.Żarty");
                Console.WriteLine("3.Korepetycje");
                Console.WriteLine("4.Biblioteka");
                Console.WriteLine("5.Wyloguj");
                string input = Console.ReadLine();
                if (!InputMethods.InputValidNumber(input,5))
                {
                    continue;
                }
                if (string.Equals(input,"5"))
                {
                    return;
                }
                ExecuteFunciontAccorrdingInput(input);
            }
            
        }
        private static void ExecuteFunciontAccorrdingInput(string input)
        {
            switch (input)
            {
                case "1":
                    AdministrationMenu.DisplayMenu(_currentUser);
                    break;
                case "2":
                    JokeManagment.JokeMenu(_currentUser);
                    break;
                case "3":
                    LessonManagemnt.LessonMenu(_currentUser);
                    break;
                case "4":
                    LibraryManagment.Librarymenu(_currentUser);
                    break;
                default:
                    break;
            }
        }
        

    }

}
