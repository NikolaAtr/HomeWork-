using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5.2 Написать программу, которая при старте дописывает текущее время в файл «startup.txt».


            string Filename = "startup.txt";   // New file )

            String text = DateTime.Now.ToString();

            Console.WriteLine(value: $"Hallo!!! {text}");

            
            File.AppendAllText(Filename, text); // запись  текста в файл text.txt

            File.AppendAllText(Filename, Environment.NewLine); //  перенос строки

            string FileText = File.ReadAllText(Filename);

            Console.WriteLine("Содержимое Файлa srartup.txt:   " + FileText);



            Console.ReadKey();



        }
    }
}
