using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  3.Написать программу, выводящую введённую пользователем строку в обратном порядке(olleH вместо Hello).


            Console.WriteLine("Введите Слово:    ");

            string slovo = Console.ReadLine();

            for (int i = slovo.Length; i > 0; i--)
            {
                Console.Write(slovo[i - 1]);  
            }


            

            Console.ReadKey();

        }

       
        
    }
                       
}
