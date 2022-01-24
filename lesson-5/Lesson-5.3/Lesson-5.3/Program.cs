using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BinaryEncoding; // new packege
namespace Lesson_5._3
{
    [Serializable]
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] nums_strings = Console.ReadLine().Split(); // числа введенные в консоль через пробел
            string nums_string = string.Join(" ", nums_strings); // массив строк превращаещь в одну строку чисел через пробел

            byte[] data = Encoding.ASCII.GetBytes(nums_string);    // строку чисел прверащешь в массив байтов

           File.WriteAllBytes("bytes.bin", data);

       

            Console.ReadKey();


        }


    }
}







