using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Мусор
{
    class Коды
    {
        static void Main(string[] args)
        {
            //Операции с дробями//
            int a, b, c, d;


            Console.WriteLine("Введите первое дробное число");

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе дробное число");

            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());

            //Сумма//
            int summ1 = a * d + b * c;
            int summ2 = b * d;

            //Вычитание//
            int min1, min2;
            min1 = a * d - b * c;
            min2 = b*d;

            //Умножение//
            int mult1, mult2;
            mult1 = a * c;
            mult2 = b * d;

            //Деление//
            int div1 = a * d;
            int div2 = b * c;
            Console.WriteLine("Сумма" + summ1 + "/" + summ2);
            Console.WriteLine("Вычитание" + min1 + "/" + min2);
            Console.WriteLine("Умножение" + mult1 + "/" + mult2);
            Console.WriteLine("Деление" + div1 + "/" + div2);
            Console.Read();
        }
    }
}
