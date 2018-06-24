using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class HomeWork32
    {//а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке).
     //Требуется подсчитать сумму всех нечетных положительных чисел.Сами числа и сумму
     //вывести на экран; Используя tryParse;//
     //tryParse защита от дурака//

        //        int a, b;
        //        b = 0;
        //            do
        //            {
        //                Console.WriteLine("Введите число. Подсчет будет вестись пока не введете 0");
        //                a = Convert.ToInt32(Console.ReadLine());

        //                if (a > 0 & a % 2 != 0)
        //                {
        //                    b++;
        //                    //Console.WriteLine("Количество нечетных положительных чисел =" + b);
        //                    //Console.ReadLine();
        //                }
        //}

        //            while (a != 0);
        //            {
        //                if (a == 0)
        //                {
        //                    Console.WriteLine("Количество нечетных положительных чисел =" + b);
        //                    Console.ReadLine();

        //                }
        static int value;
        static string console_message = "Введите число. Подсчет будет вестись пока не введете 0";
        static int GetValue(string message)
        {
            int x;
            string s;
            bool flag;

            do
            {
                Console.WriteLine(message);
                s = Console.ReadLine();
                flag = int.TryParse(s, out x);

                           }
            while (!flag);
            return x;
        }
        static void ShowValue(string description)
        {
            Console.WriteLine(description + value);
        }
        static int ReturnValue()
        {
            ShowValue("ReturnValue(до)");
            int tmp = 14;
            ShowValue("ReturnValue(после)");
            return tmp;
        }
        static void OutParametr(out int tmp)
        {
            ShowValue("OutParametr(до)");
            tmp = 14;
            ShowValue("OutParametr(после)");

        }
        static void Main(string[] args)
        {
            value = GetValue(console_message);
            Console.WriteLine("Return...");
            value = ReturnValue();
            ShowValue("value после ReturnValue");

            value = GetValue(console_message);
            Console.WriteLine("Out parametr");
            OutParametr(out value);
            ShowValue("value после Out parametr():");
        }
        
    }
}
