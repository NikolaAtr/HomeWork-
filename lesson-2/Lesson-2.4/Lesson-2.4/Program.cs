using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string refNumber = "444";                          // ПЕРЕМЕННЫЕ ОПЕРАТОРЫ В ЧЕКЕ   
            string workingOperator = "АННА КУЗНЕЦОВА";         // ПЕРЕМЕННЫЕ ОПЕРАТОРЫ В ЧЕКЕ
            string devName = "НИКОЛАЙ";                        // ПЕРЕМЕННЫЕ ОПЕРАТОРЫ В ЧЕКЕ
            string devphone = "9998675490";                    // ПЕРЕМЕННЫЕ ОПЕРАТОРЫ В ЧЕКЕ 
            string devAdress = "ясная улица";                  // ПЕРЕМЕННЫЕ ОПЕРАТОРЫ В ЧЕКЕ
            string terminalNumber = "1041365";                 // ПЕРЕМЕННЫЕ ОПЕРАТОРЫ В ЧЕКЕ


            string Good1 = "Фета ролл_________________";       // ПЕРЕМЕННЫЕ товары В ЧЕКЕ
            string Good2 = "Ролл С огурцом____________";       // ПЕРЕМЕННЫЕ товары В ЧЕКЕ
            string Good3 = "Ролл С авокадо____________";       // ПЕРЕМЕННЫЕ товары В ЧЕКЕ
            string Good4 = "Ролл Кайсо________________";       // ПЕРЕМЕННЫЕ товары В ЧЕКЕ
            string Good5 = "Ролл Овощной______________";       // ПЕРЕМЕННЫЕ товары В ЧЕКЕ
            string Good6 = "Ролл Греческий____________";       // ПЕРЕМЕННЫЕ товары В ЧЕКЕ
            string Good7 = "Ролл Темпура Овощной______";       // ПЕРЕМЕННЫЕ товары В ЧЕКЕ
            string Good8 = "Маргарита 40 тт___________";       // ПЕРЕМЕННЫЕ товары В ЧЕКЕ
            string Good9 = "при 1500 - ролл с угрем___";       // ПЕРЕМЕННЫЕ товары В ЧЕКЕ
            string Good10 ="палочки бамбук____________";       // ПЕРЕМЕННЫЕ товары В ЧЕКЕ

            int Good1prise = 230;                              // ЦЕНЫ за Товары\услуги >>
            int Good2prise = 110;
            int Good3prise = 120;
            int Good4prise = 160;
            int Good5prise = 225;
            int Good6prise = 290;
            int Good7prise = 300;
            int Good8prise = 660;
            int Good9prise = 0;
            int Good10prise = 0;

            int total = Good1prise +                    // общая цена для оплаты
                Good2prise + 
                Good3prise + 
                Good4prise + 
                Good5prise + 
                Good6prise + 
                Good7prise +
                Good8prise +
                Good9prise +
                Good10prise ;

            DateTime date = DateTime.Now;     // Дата

            System.Console.WriteLine($"    **     ОПЛАЧЕНО КАРТОЙ {total}   **  ");
            System.Console.WriteLine($"     *      SERDGIO PIZZA            *   ");
            System.Console.WriteLine($"            *Cчёт № {refNumber}          ");
            System.Console.WriteLine($"                                         ");
            System.Console.WriteLine($"                  {date}                 ");
            System.Console.WriteLine($" Оператор:  {workingOperator}            ");
            System.Console.WriteLine($" Доставка для : {devName}                ");
            System.Console.WriteLine($" Телефон: {devphone}                     ");
            System.Console.WriteLine($" Улица: {devAdress}                      ");
            System.Console.WriteLine($" www {terminalNumber}                    ");
            System.Console.WriteLine($"-----------------------------------------");
            System.Console.WriteLine($"                                         ");
            System.Console.WriteLine($"   {Good1}    {Good1prise}               ");
            System.Console.WriteLine($"   {Good2}    {Good2prise}               ");
            System.Console.WriteLine($"   {Good3}    {Good3prise}               ");
            System.Console.WriteLine($"   {Good4}    {Good4prise}               ");
            System.Console.WriteLine($"   {Good5}    {Good5prise}               "); 
            System.Console.WriteLine($"   {Good6}    {Good6prise}               ");
            System.Console.WriteLine($"   {Good7}    {Good7prise}               ");
            System.Console.WriteLine($"   {Good8}    {Good8prise}               ");
            System.Console.WriteLine($"   {Good9}    {Good9prise}               ");
            System.Console.WriteLine($"   {Good10}    {Good10prise}             ");
            System.Console.WriteLine($"-----------------------------------------");
            System.Console.WriteLine($" К оплате РУБ:             {total}       ");
            System.Console.WriteLine($"                                         ");
            System.Console.WriteLine($"    **     ОПЛАЧЕНО КАРТОЙ {total}   **  ");
            System.Console.WriteLine($"                                         ");
            System.Console.WriteLine($"            WWW.SERGIOPIZZA.ru           ");


            Console.ReadKey();

        }
    }
}
