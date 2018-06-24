using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Анкета
{
    class Program
    {
        /*Коновалова Светлана*/
        
        static void Main (string[] args)

        {
            
            

            // Написать программу “Анкета”. Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).
            //В результате   вся информация   выводится в   одну строчку. 

            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();
            
            Console.WriteLine("Ваша фамилия?");
            string surname = Console.ReadLine();
           
            Console.WriteLine("Сколько вам лет?");
            string year = Console.ReadLine();

            Console.WriteLine("Ваш рост ?");
            string stature = Console.ReadLine();

            Console.WriteLine("Сколько вы весите кг?");
            string weight = Console.ReadLine();

            //а)   используя склеивание;

            Console.WriteLine(name + " " + surname + " " + year + " " + stature + " " + weight + " ");
            Console.ReadKey();

            string[] line = new string[] { name, surname, year, stature, weight };
            string s = string.Join(" ", line);
            Console.WriteLine(s);
            Console.ReadKey();
                      
            
            //б)   используя форматированный   вывод;
            
            Console.WriteLine("Имя: {0} Фамилия: {1} Возраст: {2} Рост: {3} Вес:  {4}", name, surname, year, stature, weight);
            Console.WriteLine("{0} {1} {2} {3} {4}", name, surname, year, stature, weight);
            Console.ReadKey();

            //в)   *используя   вывод со   знаком   $  

            Console.WriteLine("${0} ${1} ${2} ${3} ${4}", name, surname, year, stature, weight);
            Console.ReadKey();

            

            //Ввести вес  и рост  человека.
            //Рассчитать и  вывести индекс  массы тела(ИМТ)  по формуле  
            //    I = m / (h * h);
            //    где m-масса тела вкилограммах,
            //    h - рост в метрах

            
            double m;
            Console.WriteLine("Сколько вы весите кг?");
            string wgt = Console.ReadLine();
            m = Convert.ToDouble(wgt);

            double h;
            Console.WriteLine("Ваш рост в метрах ?"); //вводить данные  типа 1,7
            string str = Console.ReadLine();
            h = Convert.ToDouble(str);

            double I = m / (h * h);

            Console.WriteLine("Индекс массы тела равен "+  I);
            Console.ReadKey();
            

            //а) Написать программу, которая подсчитывает расстояние между точками с координатами 
            //x1, y1 и x2,y2
            //по формуле
            //r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
            //Вывести результат используя спецификатор формата .2f(с   двумя   знаками   после   запятой);



            
            double x1;
            double x2;
            double y1;
            double y2;

            Console.WriteLine("Введите координату х1");
            string x11 = Console.ReadLine();
            Console.WriteLine("Введите координату х2");
            string x22 = Console.ReadLine();
            Console.WriteLine("Введите координату y1");
            string y11 = Console.ReadLine();
            Console.WriteLine("Введите координату y2");
            string y22 = Console.ReadLine();

            x1 = Convert.ToDouble(x11);
            x2 = Convert.ToDouble(x22);
            y1 = Convert.ToDouble(y11);
            y2 = Convert.ToDouble(y22);

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("Расстояние между точками с координатами " + x1 + ";" + x2 + ";" + y1 + ";" + y2 + "=" + "{0:F2}", r);
            //Console.WriteLine("{0:F2}", r);            
            Console.ReadKey();

             //б) *Выполните предыдущее задание оформив вычисления расстояния между точками в виде метода;
            

            //Написать программу   обмена значениями   двух переменных:  
            //а)   с использованием   третьей переменной;

            
            int z = 2;
            int po = 3;
            int l = z;
            z = po;
            m = l;
            
            //б)   *без   использования третьей   переменной.

            int bu = 3;
            int ka = 4;

            ka = ka + bu;
            bu = bu - ka;
            bu = -bu;
            ka = ka - bu;

            Console.ReadKey();



            //а)   Написать программу, которая   выводит на   экран ваше   имя,   фамилию и   город проживания.

            Console.WriteLine("Как вас зовут?");
            string nm=Console.ReadLine();

            Console.WriteLine("Ваша фамилия?");
            string snm = Console.ReadLine();

            Console.WriteLine("В каком городе вы живете?");
            string city = Console.ReadLine();

            Console.WriteLine(nm+ " " + snm + " " + city );
            Console.ReadKey();

            //б)   *Сделать   задание,   только вывод   организуйте в   центре экрана

            Console.SetCursorPosition(Console.WindowWidth/2, Console.WindowWidth/2);
            Console.WriteLine(nm + " " + snm + " " + city);
            Console.ReadKey();

            

        }
        static void Print(string ms,int x, int y)
        {

            Console.SetCursorPosition(x, y);
            Console.WriteLine(ms);

            Console.WriteLine("Как вас зовут?");
            string nm = Console.ReadLine();

            Console.WriteLine("Ваша фамилия?");
            string snm = Console.ReadLine();

            Console.WriteLine("В каком городе вы живете?");
            string city = Console.ReadLine();
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowWidth / 2);
            Console.WriteLine(nm + " " + snm + " " + city);
            Console.ReadKey();
        }


    }
    }
