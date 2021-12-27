using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_3._2
{
    internal class Program
    {
        public static string V { get; private set; }

        static void Main(string[] args)


        {

            //  2.Написать программу «Телефонный справочник» ... 


            string[,] phonees = new string [2,5];  // двумерный массив 2 Столбца, 5 строк.


            string titleName =  "Name Of My Friend";    // обьявление переменных

            string Name1 =  "          Zina";
            string Name2 =  "          IGOR";
            string Name3 =  "         MASHA";
            string Name4 =  "         SASHA";

            string titlephonees = "Phone Number";

            string phonees1 = "+7-999-867-54-90";
            string phonees2 = "+7-888-867-54-90";
            string phonees3 = "+7-777-867-54-90";
            string phonees4 = "+7-666-867-54-90";



            phonees[0, 0] = titleName;   // Заносим перемменные в массив..
            phonees[0, 1] = Name1;
            phonees[0, 2] = Name2;
            phonees[0, 3] = Name3;
            phonees[0, 4] = Name4;

            phonees[1, 0] = titlephonees;
            phonees[1, 1] = phonees1;
            phonees[1, 2] = phonees2;
            phonees[1, 3] = phonees3;
            phonees[1, 4] = phonees4;
                                                               // Выводим на консиль

            Console.WriteLine($"{phonees[0, 0]}      { phonees[1, 0]}");
            Console.WriteLine($"{phonees[0, 1]}      { phonees[1, 1]}");
            Console.WriteLine($"{phonees[0, 2]}      { phonees[1, 2]}");
            Console.WriteLine($"{phonees[0, 3]}      { phonees[1, 3]}");
            Console.WriteLine($"{phonees[0, 4]}      { phonees[1, 4]}");




            Console.ReadKey();

        }
    }
}
