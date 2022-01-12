using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_4._1
{
    internal class Program
    {
        static void Main(string[] args)

        {
           
            string FullName1 = getFullName(); // ФИО 1.  <Пользовательский Ввод>
            string FullName2 = getFullName(); // ФИО 2.  <Пользовательский Ввод>
            string FullName3 = getFullName(); // ФИО 3.  <Пользовательский Ввод>

            Console.WriteLine($"1. ФИО: {FullName1}");   // ВЫВАОД НА  КОНСОСЬ .. 
            Console.WriteLine($"2. ФИО: {FullName2}");
            Console.WriteLine($"3. ФИО: {FullName3}");

            Console.ReadKey();
        }

      
        static string getFullName()  // Метод возвращающий ФИО
        {
            System.Console.WriteLine("Введите Имя");
            string firstName = Console.ReadLine();

            
            System.Console.WriteLine("Введите Фамилию");
            string lastName = Console.ReadLine();

            System.Console.WriteLine("Введите Отчество");
            string patronymic = Console.ReadLine();

            return ($"{lastName} {firstName} {patronymic}")
                ;
           


        }

    }
}
