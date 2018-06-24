using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace HomeWork5
{
    //Коновалова Светлана
    class Program
    {
        static void Main(string[] args)
        {
            //Создать программу, которая будет проверять корректность ввода логина. Корректным
            //логином будет строка от 2 - х до 10 - ти символов, содержащая только буквы или цифры, и при
            //этом цифра не может быть первой.
            //а) без использования регулярных выражений;

            //try
            //{
            //    string login;
            //    int result;
            //    string [] a ;  

            //    //int[] a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //    //int[] a = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //    do
            //    {

            //        Console.WriteLine("Введите логин");
            //        Console.WriteLine("Если хотите остановиться, нажмите - 0 ");

            //        login = Console.ReadLine();


            //        //StringBuilder log = new StringBuilder(Console.ReadLine());
            //        //Console.WriteLine("Текущая длина строки " + log.Length);

            //        for (int n = 0; n < 10; n++)
            //        {
            //            a = new string[n];

            //            result = String.Compare(login, 0, a[n], 0, 1); //странно сравнивает, не получается 0
            //            Console.WriteLine(result);


            //            if (result <= 0)
            //            {
            //                Console.WriteLine("Ошибка формата");
            //                Console.ReadLine();

            //            }
            //            else
            //            {
            //                Console.WriteLine("Работает ли?");
            //                Console.ReadLine();
            //            }

            //            int i = 2, j = 10;

            //            if (i <= login.Length & j >= login.Length)
            //            {
            //                Console.WriteLine("Формат логина совпадает");
            //                Console.ReadLine();
            //            }

            //            else
            //            {
            //                Console.WriteLine("Попробуйте еще раз");
            //                Console.ReadLine();
            //            }
            //        }


            //    }

            //    while (login != "0");
            //    {
            //        Console.WriteLine("Хватит играться ");
            //        Console.ReadLine();
            //    }
            //}
            //catch
            //{

            //}

            try
            {
                string login;
                string login1;
                int result;
                int[] a;
                //int[] a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                //int[] a = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

                do
                {

                    Console.WriteLine("Введите логин");
                    Console.WriteLine("Если хотите остановиться, нажмите - 0 ");
                    StringBuilder log = new StringBuilder(Console.ReadLine());
                    //Console.WriteLine("Текущая длина строки " + log.Length);

                    for (int n = 0; n < 1; n++)
                    {
                        a = new int[n];

                        //Console.WriteLine("{0}", a[n]);


                        login = log.ToString();
                        login1 = a.ToString();


                        //Console.WriteLine(log.ToString());
                        //Console.WriteLine(a.ToString());

                        //Console.WriteLine(a);
                        //Console.WriteLine(login);

                        result = String.Compare(login, 0, login1, 0, 1); //странно сравнивает, не получается 0
                        //Console.WriteLine(result);


                        if (result <= 0)
                        {
                            Console.WriteLine("Ошибка формата");
                            Console.ReadLine();
                            break;
                        }
                        //else
                        //{
                        //    Console.WriteLine("Работает ли?");
                        //    Console.ReadLine();
                        //}

                        int i = 2, j = 10;

                        if (i <= log.Length & j >= log.Length)
                        {
                            Console.WriteLine("Формат логина совпадает");
                            Console.ReadLine();
                        }

                        else
                        {
                            Console.WriteLine("Попробуйте еще раз");
                            Console.ReadLine();
                        }
                    }

                    login = log.ToString();
                }

                while (login != "0");
                {
                    Console.WriteLine("Хватит играться ");
                    Console.ReadLine();
                }
            }
            catch
            {

            }

            //б) **с использованием регулярных выражений.

            Regex loginreg = new Regex("^[a-zA-Zа-яА-Я][a-zA-Zа-яА-Я0-9]{2,9}$");

            Console.WriteLine("Введите логин");
            string Login1 = (Console.ReadLine()); 

            if (loginreg.IsMatch(Login1)==true) 
            {
                Console.WriteLine("Формат логина совпадает");
            }
            else
            {
                Console.WriteLine("Ошибка формата");
            }
            Console.ReadLine();


            //а) Вывести только те слова сообщения, которые содержат не более чем n букв;

            Console.WriteLine("Введите количество букв");
            string letter = Console.ReadLine();
            int n1 = Convert.ToInt32(letter);

            Number521(n1);


            //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ;

            Console.WriteLine("Введите букву");
            string symbol = Console.ReadLine();
            Number522(symbol);


            Number523();

            //в) Найти самое длинное слово сообщения;
            //г) Найти все самые длинные слова сообщения.

            Number531();

            //*Для двух строк написать метод, определяющий, является ли одна строка перестановкой
            //другой.Регистр можно не учитывать.
            
        }

        //Разработать методы для решения следующих задач.Дано сообщение:


        //а) Вывести только те слова сообщения, которые содержат не более чем n букв;

        static void Number521(int n1)
        {

            Console.WriteLine("Введите строку");
            StringBuilder a = new StringBuilder(Console.ReadLine());
            Console.WriteLine("Исходная строка " + a);
            string part = a.ToString();




            //создаем массив разделителей
            // Разбиваем строку на части,
            // string[] parts = poems.Split(div,StringSplitOptions.RemoveEmptyEntries);

            string[] parts = part.Split(' ', ',', '.');

            //Console.WriteLine("Результат разбиения строки на части: ");
            Console.WriteLine("Слова содержащие " + n1 + " букв : ");


            for (int i = 0; i < parts.Length; i++)
            {
                //Console.WriteLine(parts[i]);

                if (n1 >= parts[i].Length)
                {
                    Console.WriteLine(parts[i]);
                }
                               
            }
            
            Console.ReadLine();

        }

        //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ;

        static void Number522(string symvol)
        {
            Console.WriteLine("Введите строку");
            StringBuilder a = new StringBuilder(Console.ReadLine());
            Console.WriteLine("Исходная строка " + a);
            string part = a.ToString();

            string[] parts = part.Split(' ', ',', '.');
            //Console.WriteLine("Результат разбиения строки на части: ");
            Console.WriteLine("Слова заканчивающиеся на " + symvol);

            for (int i = 0; i < parts.Length; i++)
            {
                //Console.WriteLine(parts[i]);


                string ku = parts[i];

                if (ku.EndsWith(symvol) == true)
                {
                    Console.WriteLine(parts[i]);
                    //Console.WriteLine(parts[i][parts[i].Length - 1]);

                }

            }

            //for (int i = 0; i < a.Length;)      
            //    if (char.IsPunctuation(a[i]))
            //        a.Remove(i, 1);
            //    else ++i;                     


            Console.ReadLine();

        }

        //в) Найти самое длинное слово сообщения;
        //г) Найти все самые длинные слова сообщения.

        static void Number523()
        {
            Console.WriteLine("Введите строку");
            StringBuilder a = new StringBuilder(Console.ReadLine());
            Console.WriteLine("Исходная строка " + a);
            string part = a.ToString();

            string[] parts = part.Split(' ', ',', '.');
            //Console.WriteLine("Результат разбиения строки на части: ");

            Console.WriteLine("Cамое длинное слово сообщения ");

            int max = 0;
            string maksimym = null;

            do
            {
                for (int i = 0; i < parts.Length; i++)
                {

                    if (parts[i].Length > max)
                    {
                        max = parts[i].Length;
                        maksimym = parts[i];

                    }
                }
                Console.WriteLine(maksimym);
            }
            while (max == 100);
            {

            }

            Console.WriteLine("Cамые длинные слова сообщения ");


            do
            {
                for (int i = 0; i < parts.Length; i++)
                {

                    if (parts[i].Length >= max)
                    {
                        max = parts[i].Length;
                        maksimym = maksimym + " " + parts[i];


                    }

                    //Console.WriteLine(max);
                    //Console.WriteLine(maksimym);
                    //Console.WriteLine(parts[i]);
                }


                Console.WriteLine(maksimym); //Как сделать так. чтобы повторно не выводил первое длинное слово?

            }
            while (max == 100);
            {

            }

            Console.ReadLine();
        }

        //Постараться разработать класс MyString.


        //*Для двух строк написать метод, определяющий, является ли одна строка перестановкой
        //другой.Регистр можно не учитывать.
                
        //Например:
        //badc являются перестановкой abcd

        static void Number531()
        {
            //а) с использованием методов C#

            

            Console.WriteLine("Введите первую строку");
            string s1 = Console.ReadLine();
            Console.WriteLine("Введите вторую строку");
            string s2 = Console.ReadLine();
            

            Console.WriteLine(s1.Select(Char.ToLower).OrderBy(x => x).SequenceEqual(s2.Select(Char.ToLower).OrderBy(x => x)));

            if (s1.Select(Char.ToLower).OrderBy(x => x).SequenceEqual(s2.Select(Char.ToLower).OrderBy(x => x)) == false)
            {
                Console.WriteLine("Одна строка НЕ является перестановкой другой");
            }
            else
            {
                Console.WriteLine("Одна строка является перестановкой другой");
            }
            Console.ReadLine();

            //б) *разработав собственный алгоритм

            //Console.WriteLine("Введите первую строку");
            //string str1 = Console.ReadLine();
            //Console.WriteLine("Введите вторую строку");
            //string str2 = Console.ReadLine();


            //string[] parts1 = str1.Split(' ', ',', '.');
            //string[] parts2 = str2.Split(' ', ',', '.');

            //if (str1.Length!=str2.Length)
            //{
            //    Console.WriteLine("Одна строка НЕ является перестановкой другой");
            //}
            //else
            //{
            //    Console.WriteLine("Одна строка является перестановкой другой");
            //}

            ////if ()
            //Console.ReadLine();
        }
        static void Number541()
        {

        }








    }




}
