using System;
namespace LessonOne
{
    class Program
    { 
        static void Main(string[] args)
        {
            var autoName = "User-Number-One";

            Console.WriteLine("Hey what is your Name?");

            var username = Console.ReadLine();
            if (username == "")
            {
                System.Console.Write("Today " + DateTime.Now + "," + autoName);
            }
            else
               


            {
                System.Console.Write("Today " + DateTime.Now + "," + username);
            }


        }
    
    }
}