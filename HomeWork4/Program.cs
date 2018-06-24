using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
   // Коновалова Светлана

    public class MyArray
    {
        //Дан целочисленный массив из 20 элементов.Элементы массива могут принимать целые
        //значения от –10 000 до 10 000 включительно.Написать программу, позволяющую найти и
        //вывести количество пар элементов массива, в которых хотя бы одно число делится на 3.
       
        //В данной задаче под парой подразумевается два подряд идущих элемента массива. Например,
        //для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.



        // Создание массива и заполение его случайными числами от минимума до максимума включительно

        int[] a;

        public MyArray (int n, int min, int max)
        {
            a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(min, max+1);

          
        }

        // найти и вывести количество пар элементов массива, в которых хотя бы одно число делится на 3.

        public int Divizion3
        {
            get
            {
                int count=0;



                for (int i = 0; i < a.Length - 1; i++)
                {
                   
                    if (a[i] != 0 & a[i] % 3 == 0 | a[i+1] != 0 & a[i + 1] % 3 == 0 )
                        {
                            count++;
                            Console.WriteLine("Пары чисел: {0} и {1}", a[i], a[i + 1]);
                        }
                    
                }
                Console.WriteLine("Количество пар " );
                return count;                   
              
                                
            }
        }
        



        //// Поиск максимального элемента массива . Свойство
        

        public int MaxCount
        {
            get
            {
                int max = a[0];
                for (int i = 0; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;

            }
        }

        //// Поиск минимального элемента массива. Свойство

        public int Min
        {
            get
            {
                int min = a[0];
                for (int i = 0; i > a.Length; i++)
                    if (a[i] < min) min = a[i];
                return min;
            }
        }

        //Выводим как строку

        public override string ToString() //Метод
        {
            string s = " ";
            foreach (int v in a)
                s = s + v + " ";
            return s;

        }


    }
    

    //2.а) Дописать класс для работы с одномерным массивом.

    //Реализовать конструктор, создающий массив заданной размерности 
    //и заполняющий массив числами от начального значения с заданным шагом.
          
    
    class NewArray
    {
        int[] b;

        public NewArray(int n, int min, int step)  //конструктор, создающий массив заданной размерности 
                                                   //и заполняющий массив числами от начального значения (min) с заданным шагом(step).
        {
            b = new int [n];
            
            for (int i = 0; i < n; i++, min = min + step) 
            b[i] = min;          
            
        }

        //Создать свойство Sum, которые возвращают сумму элементов массива,

           public int Sum
        {
            get
            {
                int sum = 0;
              
                for (int i = 0; i < b.Length; i++)
                    sum += b[i];
                return sum;
            }
            
        }
        //метод Inverse, меняющий знаки у всех элементов массива, 

        public void Inverse()
        {
            
            for (int i = 0; i < b.Length; i++)
                b[i] = -b[i];
            
        }

        //Метод Multi, умножающий каждый элемент массива на определенное число, 

        public void Multi(int k)
        {
            
            for (int i = 0; i < b.Length; i++)
                b[i] = b[i]*k;

        }

        //свойство MaxCount, возвращающее количество максимальных элементов.
        // возвращает максимальный элемент

        public int MaxCount
        {
            
            get
            {
                int max = b[0];
                int sum = 0;
                for (int i = 1; i < b.Length; i++)
                    if (b[i] > max) max = b[i];
                sum++;
                return sum;

            }
        }


        // б)*Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.



        // Вывод

        public override string ToString()
        {
            string s = " ";
            foreach (int v in b)
                s = s + v + " ";
            return s;

        }


    }

    //    Решить задачу с логинами из предыдущего урока, только логины и пароли считать из файла в
    //массив.
    class NewArrayPass
    {

        //int[] d;



        int[,] d;


        public void MyArrayPass(string Log, string Pass)
        {
            StreamReader sr1 = new StreamReader("F:\\Гик\\HomeWork4\\Login.txt");
            StreamReader sr2 = new StreamReader("F:\\Гик\\HomeWork4\\Pass.txt");

            int N = int.Parse(sr1.ReadLine());
            int M = int.Parse(sr2.ReadLine());
            d = new int[N, M];
            for (int i = 0; i != N; i++)
                for (int j = 0; j != M; j++)
                {
                    d[N, M] = int.Parse(sr1.ReadLine()) + int.Parse(sr2.ReadLine());
                }
            sr1.Close();
            sr2.Close();

        }
    }




    // 4.a. Реализовать класс для работы с двумерным массивом.

    class NewArray2
    {
        int[,] c;

        // Реализовать конструктор, заполняющий класс случайными числами

        public NewArray2(int m, int el)
        {
            c = new int[m, m];
            for (int i = 0; i < m; i++)
                for (int j = 0; j < m; j++)
                    c[i, j] = el;
        }

        public NewArray2(int m, int min, int max)
        {
            c = new int[m, m];
            Random rnd = new Random();

            for (int i = 0; i < m; i++)
                for (int j = 0; j < m; j++)
                    c[i, j] = rnd.Next(min, max+1); //чтобы максимальное включительно

        }

        //Создать методы, которые возвращают сумму всех элементов массива, 

        public int Sum()
        {

            int sum = 0;

            for (int i = 0; i < c.GetLength(0); i++)
                for (int j = 0; j < c.GetLength(1); j++)
                    sum += c[i, j];
            return sum;
        }
        // сумму всех элементов массива больше заданного, 
        public int SumMax(int k)
        {

            int sum = 0;

            for (int i = 0; i < c.GetLength(0); i++)
                for (int j = 0; j < c.GetLength(1); j++)
                    if (c[i, j] > k)
                        sum += c[i, j];
            return sum;
        }


        //свойство, возвращающее минимальный элемент массива, 

        public int Min
        {
            get
            {
                int min = c[0, 0];
                for (int i = 0; i < c.GetLength(0); i++)
                    for (int j = 0; j < c.GetLength(1); j++)
                        if (c[i, j] < min) min = c[i, j];
                return min;
            }
        }

        // свойство, возвращающее максимальный элемент массива,
        public int Max
        {
            get
            {
                int max = c[0, 0];
                for (int i = 0; i < c.GetLength(0); i++)
                    for (int j = 0; j < c.GetLength(1); j++)
                        if (c[i, j] > max) max = c[i, j];
                return max;

            }
        }
        //метод, возвращающий номер максимального элемента массива(через параметры, используя модификатор ref или out)
        // Как вывести?

        public void NumberMax(out int[] index)
        {

            int max = c[0, 0];
            int[] result = null;
            for (int i = 0; i < c.GetLength(0); i++)
                for (int j = 0; j < c.GetLength(1); j++)
                    if (c[i, j] > max)
                    {
                        max = c[i, j];
                        result = new int[] { i, j };
                    }
            index = result;
            Console.WriteLine(index);
        }
       




        public override string ToString()
        {
            string s = " ";
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)

                    s = s+c[i, j] + " ";
                s += "\n"; //переход на новую строчку}
            }



            return s;

        }

       
    }
        class Program
    {
        static void Main(string[] args)
        {
            MyArray a = new MyArray(10, -10, 1);
            NewArray b = new NewArray(20, 10,2);
            NewArray2 c = new NewArray2(2,2, 5);
            NewArrayPass d = new NewArrayPass();



            Console.WriteLine(a);            //Console.WriteLine(a.ToString());
            Console.WriteLine(a.Divizion3); //Делится на 3

            Console.WriteLine(b);
            Console.WriteLine(b.Sum);       //Cумма
            Console.WriteLine(b.MaxCount); //свойство MaxCount, возвращающее количество максимальных элементов.


            b.Inverse();                   //метод Inverse, меняющий знаки у всех элементов массива, 
            Console.WriteLine(b);

            b.Multi(3);                    //Метод Multi, умножающий каждый элемент массива на определенное число, 
            Console.WriteLine(b);


            string Log, Pass;
            Console.WriteLine("Введите логин");
            Log = Console.ReadLine();
            Console.WriteLine("Введите пароль");
            Pass = Console.ReadLine();
            d.MyArrayPass(Log,Pass);



            //Console.WriteLine(c);
            Console.WriteLine(c.ToString());

            Console.WriteLine(c.Sum()); //Метод - суммa всех элементов массива,
            Console.WriteLine(c.SumMax(3)); // сумма элементов массива больше заданного, 
            Console.WriteLine(c.Min); //свойство, возвращающее минимальный элемент массива, 
            Console.WriteLine(c.Max);// свойство, возвращающее максимальный элемент массива,

            //int[] index = { };
            //c.NumberMax(out c);
            //Console.WriteLine(index);   //метод, возвращающий номер максимального элемента массива(через параметры, используя модификатор ref или out)






            Console.ReadLine();
        }
    }










}
