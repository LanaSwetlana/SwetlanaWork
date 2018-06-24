using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeWork6
    
{
    public delegate double function(double x);

    //List<{Delegate}> 3з

    //* Модифицировать программу нахождения минимума функции так, чтобы можно было
    // передавать функцию в виде делегата.Сделать меню с различными функциями и представьте
    // пользователю выбор для какой функции и на каком отрезке находить минимум.Используйте
    // массив делегатов.


    //    Написать программу сохранения результатов вычисления заданной функции в файл для дальнейшей
    //обработки файла.Разбить программу на две функции: одна записывает данные функции в файла на
    //промежутке от a до b с шагом h, а другая считывает данные и находит минимум функции.

    class _2
    {
        
        public static double F1(double x)
        {
            return x * x - 50 * x + 10;
        }

        public static double F2(double x)
        {
            return x * x - 40 * x + 20;
        }
        public static double F3(double x)
        {
            return x * x - 30 * x + 30;
        }
        public static double F4(double x)
        {
            return x * x - 20 * x + 40;
        }

        public static void SaveFunc(string fileName, double a, double b, double h, function F)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(x));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }
        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }
        public static void HW2()
        {
            function[] F = { F1, F2, F3, F4 };
            Console.WriteLine("Введите отрезок функции от a до b");
            Console.WriteLine("Введите a:"); double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b:"); double b = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Выберите функцию: 1 - функция F1, 2 - функция F2, 3 - функция F3, 4 - функция F4");
            int numberFunc = int.Parse(Console.ReadLine());
            SaveFunc("data.bin", a, b, 0.5, F[numberFunc - 1]);

            Console.WriteLine(Load("data.bin"));
            Console.ReadKey();
        }

        ////Начальная задача

        //    Написать программу сохранения результатов вычисления заданной функции в файл для дальнейшей
        //обработки файла.Разбить программу на две функции: одна записывает данные функции в файла на
        //промежутке от a до b с шагом h, а другая считывает данные и находит минимум функции.


        //public static double F(double x)
        //{
        //    return x * x - 50 * x + 10;
        //}
        //public static void SaveFunc(string fileName, double a, double b, double h)
        //{
        //    FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
        //    BinaryWriter bw = new BinaryWriter(fs);
        //    double x = a;
        //    while (x <= b)
        //    {
        //        bw.Write(F(x));
        //        x += h; // x=x+h;
        //    }
        //    bw.Close();
        //    fs.Close();
        //}
        //public static double Load(string fileName)
        //{
        //    FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
        //    BinaryReader bw = new BinaryReader(fs);
        //    double min = double.MaxValue;
        //    double d;
        //    for (int i = 0; i < fs.Length / sizeof(double); i++)
        //    {
        //        // Считываем значение и переходим к следующему
        //        d = bw.ReadDouble();
        //        if (d < min) min = d;
        //    }
        //    bw.Close();
        //    fs.Close();
        //    return min;
        //}
        //static void Main(string[] args)
        //{
        //    SaveFunc("data.bin", -100, 100, 0.5);
        //    Console.WriteLine(Load("data.bin"));
        //    Console.ReadKey();
        //}
    }
}
