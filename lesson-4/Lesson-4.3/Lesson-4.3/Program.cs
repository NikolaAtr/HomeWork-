using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
       

            Console.WriteLine("Введите число соответствующее порядковому номеру месяца:");
            string MunthNumber = Console.ReadLine();
            int MunthInt = Convert.ToInt32(MunthNumber);

            Months Mon = (Months)MunthInt;
            PrintMon();

            if
                (MunthInt > 12 | MunthInt < 1)
                Console.WriteLine("Ошибка: введите число от 1 до 12");
            else
                Console.WriteLine(Mon.ToString());

            Console.ReadKey();

            void PrintMon ()
            {

             

                switch (Mon)
                {
                    case Months.December:
                    case Months.January:
                    case Months.February:
                        Console.WriteLine(Seasons.Winter); break;
                    case Months.March:
                    case Months.April:
                    case Months.May:
                        Console.WriteLine(Seasons.Spring); break;
                    case Months.June:
                    case Months.July:
                    case Months.August:
                        Console.WriteLine(Seasons.Summer); break;
                    case Months.September:
                    case Months.October:
                    case Months.November:
                        Console.WriteLine(Seasons.Autumn); break;
                }

                
                return ;
            } 
        }


        public enum Seasons
        {
            Winter,
            Spring,
            Summer,
            Autumn,
        }

        public enum Months
        {
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12,
        }

    }

    
}