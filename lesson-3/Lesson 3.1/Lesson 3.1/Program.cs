using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // 1. Написать программу, выводящую элементы двумерного массива по диагонали.

         

            int[,] array =  { { 1, 2, 3} , { 4, 5, 6 } };  // двумерный массив

                               // первый массив    второй массив
            Console.WriteLine($"{array[0, 0]}      { array[1, 0]}");
            Console.WriteLine($"{array[0, 1]}      { array[1, 1]}");
            Console.WriteLine($"{array[0, 2]}      { array[1, 2]}");

           
           

            Console.ReadKey();
        }
    }
}
