using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_2._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ЗАДАНИЕ 6*


          

            int office1 = 0b011110; //  Рабочие дни Офис 1
            int office2 = 0b111111; //  Рабочие дни Офис 2


            int munday =       0b100000;  // Маски дней недели
            int tuesday =      0b010000;  
            int wednsday =     0b001000;  
            int thursday =     0b000100;  
            int friday =       0b000010;  
            int saturday =     0b000001;


             int office11 = office1 | tuesday | wednsday | thursday | friday;
             int office22 = office2 | munday | tuesday | wednsday  | thursday| friday | saturday;
          

            System.Console.WriteLine($"Офис 1 работает  Вт Ср Чт Пт {office11 == office1} ");
            System.Console.WriteLine($"Офис 2 работает Пн Вт Ср Чт Пт Сб {office22 == office2} ");


            Console.ReadKey();
        }
    }
}
