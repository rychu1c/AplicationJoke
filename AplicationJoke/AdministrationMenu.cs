using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationJoke
{
    public static class AdministrationMenu
    {
        public static void DisplayMenu(CurrentUser currentUser)
        {
            if (!currentUser.LevelOfAccess.Equals("Admin"))
            {
                Console.WriteLine("Brak Dostępu");
                return;
            }
            Console.WriteLine("Nadaj prawa administatora urzytkownikowi");
            //Connect to DB and take list of all users
            //Choose Id of a user who you would like to change access level
            //then send it ,if it done return
            
        }
    }
}
