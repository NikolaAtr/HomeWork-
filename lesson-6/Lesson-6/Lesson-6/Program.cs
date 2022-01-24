using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

/* Написать консольное приложение Task Manager, которое
выводит на экран запущенные процессы и позволяет завершить указанный процесс.
Предусмотреть возможность завершения процессов с помощью указания его ID или имени процесса. 
В качестве примера можно использовать консольные утилиты Windows tasklist и taskkill.
*/




namespace Lesson_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Список текущих процессов:     ");
            System.Console.WriteLine("                              ");
            System.Console.WriteLine("ID           Name Process     ");
            System.Console.WriteLine("                              ");
            Process[] processes = Process.GetProcesses();
            
            for (int i = 0; i < processes.Length; i++)
            {
                Process process = processes[i];
                System.Console.WriteLine(process.Id  +  "     "  +  process.ProcessName); // список процессов на  локальном Компьтере
               

                
            }

            System.Console.WriteLine("                              ");
            System.Console.WriteLine("Для завершения конкретногоо процесса напишите его 'ID':      ");
            string KillProcess = Console.ReadLine();
            int KillId = Convert.ToInt32(KillProcess);

            System.Console.WriteLine("Завершить процесс " + Process.GetProcessById((int)KillId) + "???");
            System.Console.WriteLine("     yes / no    +  Enter  ");

            string killpro = Console.ReadLine();

            if (killpro == "yes")
            {
              
                 Process x =   Process.GetProcessById((int)KillId);
                x.Kill();
            }


            Console.ReadKey();


        }
    }
}
