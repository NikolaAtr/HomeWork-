using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_4._2
{
    internal class Program
    {
        static void Main()
        {
            // Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом,
            //  и возвращающую число — сумму всех чисел в строке. Ввести данные с клавиатуры
            // и вывести результат на экран.



            Console.WriteLine("Введите числа через пробел:");   
            string[] UserNumbers = Console.ReadLine().Split();  
            int[] numbers = new int[UserNumbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(UserNumbers[i]);
            }

            int sum = 0;
            for (int i = 0;i <numbers.Length;i++)
            {
                sum =sum + numbers[i];
            }

            Console.WriteLine($"Cумма всех чисел в строке составляет: {sum}");
            Console.ReadKey();



        }
    }
}
