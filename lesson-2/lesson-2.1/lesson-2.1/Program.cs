using System;
namespace Lesson_2_1
{
    class Program
    {
        static void Main(string[] args)


        {
            System.Console.WriteLine("Введите темперутуру измеренную утром (используй знак < , > после целого числа");    // Запрос температуры 1
            string temp1 = Console.ReadLine();
            double i = Convert.ToDouble(temp1);
            

            System.Console.WriteLine("Введите темперутуру измеренную днем");     // Запрос температуры 2
            string temp2 = Console.ReadLine();
            double r = Convert.ToDouble(temp2);

            System.Console.WriteLine("Введите темперутуру измеренную вечером");  // Запрос температуры 3
            string temp3 = Console.ReadLine();
            double z = Convert.ToDouble(temp3);

           double Mid = (i + r + z) / 3;
            double Mid2 = Math.Round(Mid, 1);            // округлим выходное значение



            System.Console.WriteLine( $"Ваша средняя темперетура тела сегодня составляет  { Mid2 } 'C");        // выводим средннее арифмитическое

            Console.ReadKey();
        } 
    }
}

