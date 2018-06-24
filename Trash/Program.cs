using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DoubleBinary
{
    class Program
    {
        public static double F(double x)
        {
            return x * x - 50 * x + 10;
        }
        public static void SaveFunc(string fileName, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(x));
                x += h; // x=x+h;
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
        static void Main(string[] args)
        {
            SaveFunc("data.bin", -100, 100, 0.5);
            Console.WriteLine(Load("data.bin"));
            Console.ReadKey();
        }
    }
}


//namespace Task3
//{
//    class Student
//    {
//        string lastName;
//        string firstName;
//        string univercity;
//        string faculty;
//        public int course;
//        public string department;
//        public int group;
//        public string city;
//        public int age;

        //        public string LastName
        //        {
        //            get { return lastName; }
        //        }

        //        public string FirstName
        //        {
        //            get { return firstName; }
        //        }

        //        public string Univercity
        //        {
        //            get { return univercity; }
        //        }

        //        public string Faculty
        //        {
        //            get { return faculty; }
        //        }



        //        //Создаем конструктор
        //        public Student(string firstName, string lastName, string univercity, string faculty, string department, int age, int course, int group, string city)
        //        {
        //            this.lastName = lastName;
        //            this.firstName = firstName;
        //            this.univercity = univercity;
        //            this.faculty = faculty;
        //            this.department = department;
        //            this.course = course;
        //            this.age = age;
        //            this.group = group;
        //            this.city = city;
        //        }

        //        public override string ToString()
        //        {
        //            return String.Format("{0,20}{1,15}{2,15}{3,15}{4,15}{5,15}", firstName, lastName, age, course, group, city);
        //        }
        //    }
        //    class Task3
        //    {
        //        static void CalcStud(List<Student> list)
        //        {
        //            //list.Sort(MyMethod2); //already sorted by course
        //            List<Student> newlist = new List<Student>();
        //            Student t;
        //            int[] courseFreq = new int[7]; //made 6 instead of 5 just for simplicity
        //            for (int i = 0; i < list.Count; i++)
        //            {
        //                t = list[i];
        //                if (t.age >= 18 && t.age <= 20)
        //                {
        //                    newlist.Add(t);
        //                    courseFreq[t.course]++;
        //                }
        //            }
        //            Console.WriteLine("У нас " + newlist.Count + " студентов в возрасте 18-20");
        //            Console.WriteLine("1 курс: " + courseFreq[1]);
        //            Console.WriteLine("2 курс: " + courseFreq[2]);
        //            Console.WriteLine("3 курс: " + courseFreq[3]);
        //            Console.WriteLine("4 курс: " + courseFreq[4]);
        //            Console.WriteLine("5 курс: " + courseFreq[5]);
        //            Console.WriteLine("6 курс: " + courseFreq[6]);

        //        }
        //        static int MyMethod(Student st1, Student st2)//Создаем метод для сравнения для экземпляров по возрасту
        //        {
        //            if (st1.age > st2.age) return 1;
        //            if (st1.age < st2.age) return -1;
        //            return 0;
        //        }
        //        static int MyMethod2(Student st1, Student st2)//Создаем метод для сравнения для экземпляров по номеру курса
        //        {
        //            if (st1.course > st2.course) return 1;
        //            if (st1.course < st2.course) return -1;
        //            return 0;
        //        }

        //        static int SortByAgeAndCourse(Student st1, Student st2)
        //        {
        //            if (st1.age > st2.age) return 1;
        //            if (st1.age < st2.age) return -1;
        //            if (st1.course > st2.course) return 1;
        //            if (st1.course < st2.course) return -1;
        //            return 0;
        //        }

        //        static void Main(string[] args)
        //        {
        //            int magistr = 0;
        //            int bakalavr = 0;
        //            //Создаем список студентов
        //            List<Student> list = new List<Student>();
        //            StreamReader sr = null;
        //            try
        //            {
        //                sr = new StreamReader("students_1.csv");
        //                Student t;
        //                string temp = "";
        //                string[] s;
        //                while (!sr.EndOfStream)
        //                {
        //                    try
        //                    {
        //                        temp = sr.ReadLine();
        //                        s = temp.Split(';');
        //                        //Добавляем в список новый экземляр класса Student
        //                        t = new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), Convert.ToInt32(s[6]), int.Parse(s[7]), s[8]);
        //                        list.Add(t);
        //                        //Одновременно подсчитываем кол-во бакалавров и магистров
        //                        if (t.course < 5) bakalavr++; else magistr++;
        //                    }
        //                    catch (ArgumentNullException e)
        //                    {

        //                    }
        //                    catch (ArgumentException exc)
        //                    {

        //                    }
        //                    catch (Exception e)
        //                    {
        //                        //throw new Exception();
        //                        Console.WriteLine(e.Message);
        //                        Console.WriteLine(temp);
        //                    }
        //                }
        //            }
        //            catch
        //            {

        //            }
        //            finally//try
        //            {
        //                if (sr != null) sr.Close();
        //            }

        //            Console.WriteLine("Всего студентов:" + list.Count);
        //            Console.WriteLine("Учащихся на 5 и 6 курсах (магистров):{0}", magistr); //учащихся на 5 и 6 курсах;

        //            List<Student> list2 = new List<Student>(); //Lets make copy of original list to compare results
        //            list2 = list;

        //            list2.Sort(SortByAgeAndCourse); //sort using method, proposed at lecture

        //            list.Sort(MyMethod); //отсортировать список по возрасту студента;
        //            list.Sort(MyMethod2); //теперь список будет отсоертирован и по курсу

        //            if (list.ToArray() == list2.ToArray())
        //            {
        //                Console.WriteLine("Yes, both methods return same result");
        //            }
        //            else
        //            {
        //                Console.WriteLine("No, methods return different result");
        //            }

        //            CalcStud(list);//подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(частотный массив);
        //            Console.ReadKey();
        //        }
        //    }

        //}
//    namespace Trash
//{
//    // 1. Сколько всего студентов?
//    //2. Сколько всего бакалавров?
//    //3. Сколько всего магистров?
//    //4. Вывести всех студентов(по ФИО) в алфавитном порядке

//    using System;
//    using System.Collections.Generic;
//    using System.IO;
//    class Student
//    {
//        public string lastName;
//        public string firstName;
//        public string univercity;
//        public string faculty;
//        public int course;
//        public string department;
//        public int group;
//        public string city;
//        int age;
//        // Создаем конструктор
//        public Student(string firstName, string lastName, string univercity, string faculty, string department, int
//        age, int course, int group, string city)
//        {
//            this.lastName = lastName;
//            this.firstName = firstName;
//            this.univercity = univercity;
//            this.faculty = faculty;
//            this.department = department;
//            this.course = course;
//            this.age = age;
//            this.group = group;
//            this.city = city;
//        }
//    }
//    class Program
//    {
//        // Выводим в алфавитном порядке
//        static int MyDelegat(Student st1, Student st2) //Создаем метод для сравнения для экземпляров
//        {
//            int res = String.Compare(st1.firstName, st2.firstName); // Сравниваем две строки
//            if (res == 0) return String.Compare(st1.lastName, st2.lastName);
//            else return res;

//        }
//        static void Main(string[] args)
//        {
//            int bakalav = 0;
//            int magistr = 0;
//            List<Student> list = new List<Student>(); // Создаем список студентов
//            DateTime dt = DateTime.Now;
//            StreamReader sr = new StreamReader("students_6.csv");
//            while (!sr.EndOfStream)
//            {
//                try
//                {
//                    string[] s = sr.ReadLine().Split(';');
//                    // Добавляем в список новый экземпляр класса Student
//                    list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
//                    // Одновременно подсчитываем количество бакалавров и магистров
//                    if (int.Parse(s[6]) < 5) bakalav++; else magistr++;
//                }
//                catch (Exception e)
//                {
//                    Console.WriteLine(e.Message);
//                    Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
//                    // Выход из Main
//                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;
//                }
//            }
//            sr.Close();
//            list.Sort(new Comparison<Student>(MyDelegat));
//            Console.WriteLine("Всего студентов:" + list.Count);
//            Console.WriteLine("Магистров:{0}", magistr);
//            Console.WriteLine("Бакалавров:{0}", bakalav);

//            foreach (var v in list) Console.WriteLine(v.firstName);
//            Console.WriteLine(DateTime.Now - dt);
//            Console.ReadKey();
//        }
//    }
//}


//// Описываем делегат. В делегате описывается сигнатура методов, на
//// которые сможет ссылаться делегат в дальнейшем (хранить в себе)
//public delegate double Fun(double x);

//class Program
//{
//    // Создаем метод, который принимает делегат
//    // То есть на практике, этот метод сможет принимать любой метод
//    // с такой же сигнатурой как у делегата

//    public static void Table(Fun F, double x, double b)
//    {
//        Console.WriteLine("----- X ----- Y -----");
//        while (x <= b)
//        {
//            Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x));
//            x += 1;
//        }
//        Console.WriteLine("---------------------");
//    }

//    // Создаем метод для передачи его в качестве параметра в Table

//    public static double MyFunc(double x)
//    {
//        return x * x * x;
//    }
//    static void Main()
//    {
//        // Создаем новый делегат и передаем ссылку на него в метод Table
//        Console.WriteLine("Таблица функции MyFunc:");
//        // Параметры метода и тип возвращаемого значения, должны совпадать с делегатом
//        Table(new Fun(MyFunc), -2, 2);
//        Console.WriteLine("Еще раз та же таблица, но вызов организован по новому");
//        // Упрощение(c C# 2.0).Делегат создается автоматически.
//        Table(MyFunc, -2, 2);
//        Console.WriteLine("Таблица функции Sin:");
//        Table(Math.Sin, -2, 2); // Можно передавать уже созданные методы
//        Console.WriteLine("Таблица функции x^2:");
//        // Упрощение(с C# 2.0). Использование анонимного метода
//        Table(delegate (double x) { return x * x; }, 0, 3);
//        Console.ReadLine();

//    }
//}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        String scv = "Около кола-колокола";
    //        scv.Replace("о", "");
    //        Console.WriteLine(scv);


    //        String s = "Около кола-колокола";
    //        Console.WriteLine("The initial string: '{0}'", s);
    //        s = s.Replace("a", "b").Replace("b", "c").Replace("c", "d");
    //        Console.WriteLine("The final string: '{0}'", s);
    //        Console.ReadLine();
    //    }
    //    static void Sell()
    //    {

    //        //string login;

    //        ////Console.WriteLine("Введите логин");
    //        ////login = Console.ReadLine();

    //        ////char[] div = { '/' };  // создаем массив разделителей
    //        ////                       // разбиваем строку на части,
    //        ////string[] parts = login.Split(div);
    //        ////Console.WriteLine("Результат разбиения строки на части");
    //        ////for (int i = 0; i < parts.Length; i++)
    //        ////    Console.WriteLine(parts[i]);

    //        ////string str = string.Join("|", parts);
    //        ////Console.WriteLine("Результат сборки");
    //        ////Console.WriteLine(str);


    //        ////StringBuilder a = new StringBuilder(10);
    //        ////string stra = a.ToString();
    //        ////StringBuilder b = new StringBuilder(2);
    //        ////string strb = b.ToString();

    //        ////string a = "фывапрогнп";
    //        ////string b = "ку";


    //        ////Сравнение с использованием статического метода (без учета регистра)
    //        ////Console.WriteLine(String.Compare(login, strb, true));

    //        ////int c = String.Compare(login, stra, true);
    //        ////int d = String.Compare(login, strb, true);

    //        ////if (c == 0 & d == -1 | c == 1 & d == 0 | c == 1 & d == -1)

    //        ////int c = String.Compare(login, a, true);
    //        ////int d = String.Compare(login, b, true);

    //        //do
    //        //{
    //        //    Console.WriteLine("Введите логин");
    //        //    login = Console.ReadLine();

    //        //    string a = "фывапрогнп";
    //        //    string b = "ку";

    //        //    int c = String.Compare(login, a, true);
    //        //    int d = String.Compare(login, b, true);

    //        //    if (c == 0 & d == -1 | c == 1 & d == 0 | c == 1 & d == -1)
    //        //    {
    //        //        Console.WriteLine("удачно");
    //        //        Console.ReadLine();
    //        //    }
    //        //    if (c == 0 & d == 1 | c == -1 & d == 0 | c == -1 & d == 1)
    //        //    {
    //        //        Console.WriteLine("Наоборот");
    //        //        Console.ReadLine();
    //        //    }
    //        //    else
    //        //    {
    //        //        Console.WriteLine("Чтото не то");
    //        //        Console.ReadLine();
    //        //    }
    //        //}
    //        //while (login != "0");
    //        //if(login=="0")
    //        //{
    //        //    Console.WriteLine("Хватит пытаться =");
    //        //    Console.ReadLine();
    //        //}



    //        //////Сравнение с использованием не статического метода (с учетом регистра)
    //        ////Console.WriteLine(a.CompareTo(b));
    //        //Console.ReadLine();
    //    }
    //}
//}
