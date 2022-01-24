using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Lesson_5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.

            string Filename = "text.txt";   // New file )

            Console.WriteLine("Введите текст, он будет сохранен в файл");

            String text = Console.ReadLine();

            File.AppendAllText(Filename,text); // запись  текста в файл text.txt

            File.AppendAllText(Filename, Environment.NewLine); //  перенос строки

            string FileText = File.ReadAllText(Filename);

            Console.WriteLine("Содержимое Файлa text.txt:   " +  FileText);

           

            Console.ReadKey();

        }
    }
}
