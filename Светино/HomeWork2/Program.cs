using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    /*Коновалова Светлана*/
    {
        static void Main(string[] args)
        {
            ////Написать метод возвращающий минимальное из трех чисел.

            double a, b, c;

            Console.WriteLine("Введите число a");
            string a1 = Console.ReadLine();
            Console.WriteLine("Введите число b");
            string b1 = Console.ReadLine();
            Console.WriteLine("Введите число c");
            string c1 = Console.ReadLine();

            a = Convert.ToDouble(a1);
            b = Convert.ToDouble(b1);
            c = Convert.ToDouble(c1);

            if (a < b & a < c)
            {
                Console.WriteLine("Минимальное число а" + "=" + a);
                Console.ReadLine();
            }
                if (b < a & b < c)
                {
                    Console.WriteLine("Минимальное число b" + "=" + b);
                    Console.ReadLine();
                }
                if (c < a & c < b)
                {
                    Console.WriteLine("Минимальное число c" + "=" + c);
                    Console.ReadLine();
                }
            
            else
            {
                Console.WriteLine("Нет минимального числа");
                Console.ReadLine(); /*Скорее всего тут оператор if еще один нужен*/
            }
            Number22();
            Number23();
            Number24();
            Number25();
            Number26();
            Number27();
            Number28( 11, 88);
            Console.ReadLine();
            Number28(1, 5);
            Console.ReadLine();
        }
        static void Number22()
        {
            ////Написать метод подсчета количества цифр числа

            Console.WriteLine("Введите число");

            int num = int.Parse(Console.ReadLine());
            Console.WriteLine((int)Math.Log10(num) + 1);
            Console.ReadLine();

        }
        static void Number23()
        {
            //С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных        
            //положительных чисел.

            int a, b;
            b = 0;
            do
            {
                Console.WriteLine("Введите число. Подсчет будет вестись пока не введете 0");
                a = Convert.ToInt32(Console.ReadLine());

                if (a > 0 & a % 2 != 0)
                {
                    b++;
                    //Console.WriteLine("Количество нечетных положительных чисел =" + b);
                    //Console.ReadLine();
                }
            }

            while (a != 0);
            {
                if (a == 0)
                {
                    Console.WriteLine("Количество нечетных положительных чисел =" + b);
                    Console.ReadLine();

                }

            }


        }
        static void Number24()
        {
            //Реализовать метод проверки логина и пароля. На вход подается логин и пароль. На выходе
            //истина, если прошел авторизацию, и ложь, если не прошел(Логин:root, Password: GeekBrains).
            //Используя метод проверки логина и пароля, написать программу: пользователь вводит логин
            //и пароль, программа пропускает его дальше или не пропускает.С помощью цикла do while
            //ограничить ввод пароля тремя попытками.


            string Log, Pass;
            int a;
            int n = 0;
            do
            {
                Console.WriteLine("Введите логин");
                Log = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                Pass = Console.ReadLine();
                n++;
                a = 3 - n;
                if (Log != "root" & Pass != "GeekBrains")
                {

                    Console.WriteLine("Не верно." + "Количество оставшихся попыток" + a);
                    Console.WriteLine("Попробуйте еще раз");
                    Console.ReadLine();

                }
                if (Log == "root" & Pass == "GeekBrains")
                {
                    Console.WriteLine("Все верно, милости прошу");
                    Console.ReadLine();
                    Login();
                    break;

                }
            }
            while (a != 0);
            {
                //Console.ReadLine();

                if (a == 0)
                {
                    Console.WriteLine("Количество попыток исчерпано");
                    Console.ReadLine();
                }

            }


        }
        static void Login()
        {
            Console.WriteLine("Продолжайте работу");
            Console.ReadLine();
        }
        static void Number25()
        {
            //а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс
            //массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;

            Console.WriteLine("Ваш рост см?");
            double stature = double.Parse(Console.ReadLine());
            stature = stature / 100; /* Переводим рост в метры*/

            Console.WriteLine("Сколько вы весите кг?");
            double weight = double.Parse(Console.ReadLine());

            double I = weight / (stature * stature);

            Console.WriteLine("Индекс массы тела равен " + "{0:F2}", I);
            Console.ReadKey();


            if (I <= 16)
            {
                Console.WriteLine("Дефицит массы. Вам настоятельно рекомендуется набрать вес ");
                Console.ReadKey();

            }
            if (16 < I & I <= 18.5)
            {
                Console.WriteLine("Недостаточная масса тела. Вам настоятельно рекомендуется набрать вес");
                Console.ReadKey();
            }
            if (18.5 < I & I <= 25)
            {
                Console.WriteLine("Норма");
                Console.ReadKey();
            }
            if (25 < I & I <= 30)
            {
                Console.WriteLine("Избыточная масса тела. Рекомендуем сбросить вес");
                Console.ReadKey();
            }
            if (30 < I & I <= 35)
            {
                Console.WriteLine("Ожирение первой степени. Настоятельно рекомендуем сбросить вес");
                Console.ReadKey();
            }
            if (35 < I & I <= 40)
            {
                Console.WriteLine("Ожирение второй степени. Настоятельно рекомендуем сбросить вес");
                Console.ReadKey();
            }
            if (40 < I)
            {
                Console.WriteLine("Ожирение третьей степени. Настоятельно рекомендуем сбросить вес, вам требуется лечение");
                Console.ReadKey();
            }


        }
        static void Number26()
        //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
        {
            double m;
            Console.WriteLine("Ваш рост см?");
            double stature = double.Parse(Console.ReadLine());
            stature = stature / 100; /* Переводим рост в метры*/

            Console.WriteLine("Сколько вы весите кг?");
            double weight = double.Parse(Console.ReadLine());

            double I = weight / (stature * stature);

            Console.WriteLine("Индекс массы тела равен " + "{0:F2}", I);
            Console.ReadKey();


            if (I <= 16)
            {
                Console.WriteLine("Дефицит массы. Вам настоятельно рекомендуется набрать вес.");
                Console.ReadKey();

            }
            if (16 < I & I <= 18.5)
            {
                Console.WriteLine("Недостаточная масса тела. Вам настоятельно рекомендуется набрать вес");
                Console.ReadKey();
            }
            if (18.5 < I & I <= 25)
            {
                Console.WriteLine("Норма");
                Console.ReadKey();
            }
            if (25 < I & I <= 30)
            {
                Console.WriteLine("Избыточная масса тела. Рекомендуем сбросить вес");
                Console.ReadKey();
            }
            if (30 < I & I <= 35)
            {
                Console.WriteLine("Ожирение первой степени. Настоятельно рекомендуем сбросить вес");
                Console.ReadKey();
            }
            if (35 < I & I <= 40)
            {
                Console.WriteLine("Ожирение второй степени. Настоятельно рекомендуем сбросить вес");
                Console.ReadKey();
            }
            if (40 < I)
            {
                Console.WriteLine("Ожирение третьей степени. Настоятельно рекомендуем сбросить вес, вам требуется лечение");
                Console.ReadKey();
            }

            if (I < 18.5)
            {
                m = 18.5 - I;
                Console.WriteLine("Наберите " + "{0:F2}", m);
                Console.ReadKey();
            }
            if (I > 25)
            {
                m = I - 18.5;
                Console.WriteLine("Сбросьте " + "{0:F2}", m);
                Console.ReadKey();
            }

        }
        static void Number27()
        {
            ////*Написать программу подсчета количества “Хороших” чисел в диапазоне от 1 до 1 000 000
            ////000.Хорошим называется число, которое делится на сумму своих цифр.Реализовать подсчет
            ////времени выполнения программы, используя структуру DateTime.

            DateTime start = DateTime.Now;

            int sum = 1;
            double fact = 1;
            for (int i = 1; i <= 1000000000; i++)
            {
                fact *= i;
                //Console.WriteLine("Факториал числа "+ i +"="+ fact);
                if (fact != 0)
                {
                    sum++;
                }
            }
            Console.WriteLine("Факториал = " + fact);
            Console.WriteLine("Хорошие числа = " + sum);


            DateTime finish = DateTime.Now;
            Console.WriteLine(finish - start);
            Console.ReadKey();
        }
        static void Number28(int a, int b )
        {
            //a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a < b);

            Console.Write(a);

            if (a<b)
            {
                Number28(a + 1, b);
            }
        }
        static void Number29()
        {
            //б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.

           int f=1;
            Console.Write(f);
           
            Number28(1, 2);
            //f *= Number28 (a,b);
            //Number29 (f*);



        }

    }
}
        
    
