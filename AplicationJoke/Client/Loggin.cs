using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationJoke.Client
{
    public class Loggin
    {
        public static CurrentUser LogInToSystem()
        {
            while (true)
            {
                //Take user login 
                string loginInput = Console.ReadLine();
                //Take user password
                string passwordInput = Console.ReadLine();
                if (string.IsNullOrEmpty(loginInput) || string.IsNullOrEmpty(passwordInput))
                {
                    continue;
                }
                //Connect to DB to check if login and password check match with user collection
                //NO IMPLEMENTATION
                //if it match take user and save it in object CurrentUser
                CurrentUser currentUser = new CurrentUser();
                return currentUser;
                //
            }

        }
    }
}
