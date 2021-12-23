using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

          

            Console.ReadKey();












        }
    }
}
