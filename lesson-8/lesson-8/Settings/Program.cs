using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Settings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson-8");
            Console.WriteLine("");
            Console.WriteLine($" appScope:  { Properties.Settings.Default.appScope}");
            Console.WriteLine($" userScope: { Properties.Settings.Default.userScope}");
            Console.WriteLine("");

            Properties.Settings.Default.userScope = getInfoFromUser();
            Properties.Settings.Default.Save();





        }
            public static string getInfoFromUser() // Метод info от пользователя.


            {
                System.Console.WriteLine("Введите Имя");
                string userName = Console.ReadLine();

                System.Console.WriteLine("Введите ваш возраст");
                string userAge = Console.ReadLine();

                System.Console.WriteLine("Введите ваш род деятельности");
                string userCareer = Console.ReadLine();

                return ($"{userName} {userAge} {userCareer}");

            }

            
        
    }
}
