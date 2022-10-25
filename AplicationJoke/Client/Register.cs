using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationJoke.Client
{
    public class Register
    {

        public static bool RegistrationFormula()
        {
            string loginFormula = InputMethods.GetInput("Podaj swój login");
            //Connect to DB,if login is not already take continue collecting data from the user in case of registration otherwise return.
            if (IsLoginTaken(loginFormula))
            {
                return false;
            }
            string nameFormula = InputMethods.GetInput("Podaj swoje imię");
            string surnameFormula = InputMethods.GetInput("Podaj swoje nazwisko");
            string statusFormula = InputMethods.GetInput("Jestes uczniem czy korepetytorem?");
            string locationFormula = InputMethods.GetInput("Podaj region logowania");
            new CurrentUser(loginFormula, nameFormula, surnameFormula, statusFormula, locationFormula);
            //Send object Peron  to DB
            return true;
        }
        private static bool IsLoginTaken(string loginName)
        {
            Console.WriteLine("IsLoginTaken Implementation");
            return false;
        }
        private static bool IsObjectSent(object obj)
        {
            Console.WriteLine("Implemantation");
            return true;
        }
    }
}
