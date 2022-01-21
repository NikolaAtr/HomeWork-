using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_3._4
{
    internal class Program
    {
        static void Main(string[] args)


        {
            // *«Морской бой»


            string [,] battle = new string[10, 10];


            for (int i = 0; i < battle.GetLength(0); i++)
            {
                for (int j = 0; j < battle.GetLength(1); j++)
                {
                    battle[i,j] = "O";  // Все элементы массива принимаем "O"


                    battle[2, 2] = "X";
                    battle[2, 3] = "X";
                    battle[2, 4] = "X";          // 4 deck(1)
                    battle[2, 5] = "X";

                    battle[9, 0] = "X";
                    battle[9, 1] = "X";    // 3 deck(1)
                    battle[9, 2] = "X";

                    battle[5, 0] = "X";
                    battle[5, 1] = "X";    // 3 deck(2)
                    battle[5, 2] = "X";

                    battle[7, 8] = "X";         // 2 deck(1)
                    battle[7, 7] = "X";

                    battle[7, 5] = "X";         // 2 deck(2)
                    battle[7, 4] = "X";

                    battle[9, 9] = "X";         // 2 deck(3)
                    battle[9, 8] = "X";

                    battle[1, 9] = "X";    // 1 deck(1)

                    battle[1, 7] = "X";    // 1 deck(2)

                    battle[0, 4] = "X";    // 1 deck(3)

                    battle[0, 6] = "X";    // 1 deck(4)


                    System.Console.Write($"{battle[i, j]} ");
                }
                System.Console.WriteLine();


            }
            Console.ReadKey();
        }
    }
}
