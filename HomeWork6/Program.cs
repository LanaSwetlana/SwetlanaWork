using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeWork6
{ /*Коновалова Светлана*/

    // 1. Изменить программу вывода функции так, чтобы можно было передавать функции типа
    //double(double, double).Продемонстрировать работу на функции с функцией a*x ^ 2 и функцией
    //a* sin(x).

    //Описываем делегат. В делегате создаем сигнатуру методов (double (double a, double x)),
    //На которые сможет ссылать делегат в дальнейшем(хранить в себе)

    public delegate double Dub(double a, double x);


    class Program
    {
        //Создаем метод, который принимает делегат
        //    Этот медод сможет принимать любой метод с такойже сигнатурой, как у делегата

        public static void Table(Dub D, double a, double x)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= a)
            {

                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, D(a, x));
                x += 1;
            }
            while (x > a)
            {

                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", a, D(a, x));
                a += 1;
            }

            Console.WriteLine("---------------------");
        }
        public static double Fun1(double a, double x)
        {
            return a * x * x;
        }
        public static double Fun2(double a, double x)
        {
            return a * Math.Sin(x);
        }


        static void Main(string[] args)
        {
            // Создаем новый делегат и передаем ссылку на него в метод Table
            Console.WriteLine("Таблица функции Fun1:");

            // Параметры метода и тип возвращаемого значения, должны совпадать с делегатом
            Table(new Dub(Fun1), 2, -2);

            Console.WriteLine("Еще раз та же таблица, но вызов организован по новому");
            // Упрощение(c C# 2.0).Делегат создается автоматически.
            Table(Fun1, -2, 2);

            Console.WriteLine("Таблица функции a*x^2:");
            // Упрощение(с C# 2.0). Использование анонимного метода
            Table(delegate (double a, double x) { return a * x * x; }, 0, 3);

            Console.WriteLine("Таблица функции Fun2:");
            Table(new Dub(Fun2), -2, 2);
            Table(Fun2, -2, 2);
            Table(delegate (double a, double x) { return a * Math.Sin(x); }, 1, 4);


            Console.ReadLine();



            ////2 задача
            //_2.HW2();

            ////3 задача
            Student.Kurs();



        }
    }
}
