using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // "ТЕМПЕРАТУРА () "
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

            System.Console.WriteLine($"Ваша средняя темперетура тела сегодня составляет  { Mid2 } 'C");        // выводим средннее арифмитическое

            //  "НОМЕР МЕСЯЦА ()  "  

            // Запрос у пользователя порядкого номера текущего месяца

            System.Console.WriteLine("Введи номер текущего месяца");
            string munthNumber = System.Console.ReadLine();

            // Выводим название текущего месяца

            if (munthNumber == "1")
            {
                Console.WriteLine("Текущий месяц 'Январь'");
            }


            else if (munthNumber == "2")
            {
                Console.WriteLine("Текущий месяц 'Февраль'");
            }

            else if (munthNumber == "3")
            {
                Console.WriteLine("Текущий месяц 'Март'");
            }

            else if (munthNumber == "4")
            {
                Console.WriteLine("Текущий месяц 'Апрель'");
            }

            else if (munthNumber == "5")
            {
                Console.WriteLine("Текущий месяц 'Май'");
            }

            else if (munthNumber == "6")
            {
                Console.WriteLine("Текущий месяц 'Июнь'");
            }

            else if (munthNumber == "7")
            {
                Console.WriteLine("Текущий месяц 'Июль'");
            }

            else if (munthNumber == "8")
            {
                Console.WriteLine("Текущий месяц 'Август'");
            }

            else if (munthNumber == "9")
            {
                Console.WriteLine("Текущий месяц 'Сентябрь'");
            }

            else if (munthNumber == "10")
            {
                Console.WriteLine("Текущий месяц 'Окрябрь'");
            }

            else if (munthNumber == "11")
            {
                Console.WriteLine("Текущий месяц 'Ноябрь'");
            }

            else if (munthNumber == "12")
            {
                Console.WriteLine("Текущий месяц 'Декабрь'");
            }
// Задание 5
            if (munthNumber == "11" || munthNumber == "1" || munthNumber == "2" && Mid2 > 0)  // Условия для вывода сообщения "Холодная была зима"
            {
                Console.WriteLine("Холодная была зима!");
            }
            else
            Console.WriteLine("=)");  // Если условия не выполнены



            Console.ReadKey();


            






        }
    }
}
