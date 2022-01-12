using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            // Формула Фибаначи: f(n)=f(n-1) + f(n-2), где f(0)=0, f(1)=1.


            Console.WriteLine("Введите число для расчета ЧИСЛА ФИБАНАЧИ");
            string StringI = Console.ReadLine();                           // Значение для расчета Фибаначи от пользоавтеля
            int i = Convert.ToInt32(StringI);


           

            if (i > 100)

                Console.WriteLine("Введите число меньше 100! ");          // Ограничим пользовательский ввод до 100
            
            else
            {
                int fib = Fibonachi(i);
                Console.WriteLine($"{i} число Фибоначчи = {fib}");

            }

            int Fibonachi(int n)
            {
                if (n == 0 || n == 1)  // f(0)=0, f(1)=1.
                    return n;

                return Fibonachi(n - 1) + Fibonachi(n - 2); // f(n)=f(n-1) + f(n-2)


            }
          


            Console.ReadKey();


        }

      
    }
}
