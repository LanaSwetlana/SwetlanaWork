using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    class Program
    { 
        static void Pause()
        {
            Console.ReadKey();
        }
        static void Pause(string msq)
        {
            Console.WriteLine(msq);
            Console.ReadKey();
        }


        //    double a =3.14;
        //    int b = (int)a;

        //    Console.WriteLine("Ура мне!" + "\'ты");
        //    Console.WriteLine("{0:C7}", 12345);

        //    double x;
        //    string str = Console.ReadLine();


        //}
        //static int Sqr(int x)
        //    {
        //        return x * x;
        //    }
        static void Main(string[] args)
        {
            Pause("Перегруженный метод");
            Pause();
            //int value = 8;
            //Console.WriteLine("Квадрат числа" + value + "=" + Sqr(value));
        }
    }
}
