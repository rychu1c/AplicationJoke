using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationJoke
{
    public static class LessonManagemnt
    {
        public static void LessonMenu(CurrentUser currentUser)
        {
            if (string.Equals(currentUser.Status,"Uczeń"))
            {
                ApprenticeMenu(currentUser);
            }
            if (string.Equals(currentUser.Status,"Korepetytor"))
            {
                TutorMenu(currentUser);
            }
        }
        public static void ApprenticeMenu(CurrentUser currentUser)
        {
            Console.WriteLine("1.Zapisz sie na lekcje");
        }
        public static void TutorMenu(CurrentUser currentUser)
        {
            Console.WriteLine("1.Zarządzaj swoimi lekcjami");
        }
    }
}
