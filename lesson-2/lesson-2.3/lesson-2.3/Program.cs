using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // запрос числа у пользователя

           System.Console.WriteLine("Введите число");

 string number =System.Console.ReadLine(); // strint to int

            int i = Convert.ToInt32(number);

            if (i % 2 == 0)  // проверка числа на четность
                 
                System.Console.WriteLine("Число чётное");

            else            // в случае если число не четное 
                System.Console.WriteLine("Число не четное");

            Console.ReadKey();



        }
    }
}
