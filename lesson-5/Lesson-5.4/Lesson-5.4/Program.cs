using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_5._4
{
    internal class Program
    {

        // (*) Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с рекурсией и без.
        static void Main(string[] args)
        {


            string Filename = "console.txt";   

            string currentDirectory = Directory.GetCurrentDirectory();  // use local Dir for HomeWork
            System.Console.WriteLine("Теуцщая дириктория:  " + currentDirectory);





            foreach (string file in Directory.EnumerateFileSystemEntries(currentDirectory))

            {
                Console.WriteLine(file);
                File.AppendAllText(Filename, file);
                File.AppendAllText(Filename, Environment.NewLine);

            }


            Console.ReadKey();

        }

    }
}
