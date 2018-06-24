using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    //Описываем делегат. В делегате создаем сигнатуру методов (double (double a, double x)),
    //На которые сможет ссылать делегат в дальнейшем(хранить в себе)

    public delegate double Dub2(double b, double x); /*(double (double a, double x))*/

    delegate double Fun(double b);                     /* (double (double a)*/
    delegate void Dub4(double x, int x2);               /*(void (double a, int x))*/



    class DubShablon
    {
    //     // 1. Сколько всего студентов?
    ////2. Сколько всего бакалавров?
    ////3. Сколько всего магистров?
    ////4. Вывести всех студентов(по ФИО) в алфавитном порядке
    
    //using System;
    //using System.Collections.Generic;
    //using System.IO;
    //class Student
    //{
    //    public string lastName;
    //    public string firstName;
    //    public string univercity;
    //    public string faculty;
    //    public int course;
    //    public string department;
    //    public int group;
    //    public string city;
    //    int age;
    //    // Создаем конструктор
    //    public Student(string firstName, string lastName, string univercity, string faculty, string department, int
    //    age, int course, int group, string city)
    //    {
    //        this.lastName = lastName;
    //        this.firstName = firstName;
    //        this.univercity = univercity;
    //        this.faculty = faculty;
    //        this.department = department;
    //        this.course = course;
    //        this.age = age;
    //        this.group = group;
    //        this.city = city;
    //    }
    //}
    //class Program
    //{
    //    // Выводим в алфавитном порядке
    //    static int MyDelegat(Student st1, Student st2) //Создаем метод для сравнения для экземпляров
    //    {
    //        int res = String.Compare(st1.firstName, st2.firstName); // Сравниваем две строки
    //        if (res == 0) return String.Compare(st1.lastName, st2.lastName);
    //        else return res;

    //    }
    //    static void Main(string[] args)
    //    {
    //        int bakalav = 0;
    //        int magistr = 0;
    //        List<Student> list = new List<Student>(); // Создаем список студентов
    //        DateTime dt = DateTime.Now;
    //        StreamReader sr = new StreamReader("students_6.csv");
    //        while (!sr.EndOfStream)
    //        {
    //            try
    //            {
    //                string[] s = sr.ReadLine().Split(';');
    //                // Добавляем в список новый экземпляр класса Student
    //                list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
    //                // Одновременно подсчитываем количество бакалавров и магистров
    //                if (int.Parse(s[6]) < 5) bakalav++; else magistr++;
    //            }
    //            catch (Exception e)
    //            {
    //                Console.WriteLine(e.Message);
    //                Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
    //                // Выход из Main
    //                if (Console.ReadKey().Key == ConsoleKey.Escape) return;
    //            }
    //        }
    //        sr.Close();
    //        list.Sort(new Comparison<Student>(MyDelegat));
    //        Console.WriteLine("Всего студентов:" + list.Count);
    //        Console.WriteLine("Магистров:{0}", magistr);
    //        Console.WriteLine("Бакалавров:{0}", bakalav);

    //        foreach (var v in list) Console.WriteLine(v.firstName);
    //        Console.WriteLine(DateTime.Now - dt);
    //        Console.ReadKey();
    //    }
    //}

    //////=======================================================================================

    //public static void Table(Fun F, double x, double b)
    //{
    //    Console.WriteLine("----- X ----- Y -----");
    //    while (x <= b)
    //    {
    //        Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x));
    //        x += 1;
    //    }
    //    Console.WriteLine("---------------------");
    //}
    //// Создаем метод для передачи его в качестве параметра в Table
    //public static double MyFunc(double x)
    //{
    //    return x * x * x;
    //}
    //static void Main()
    //{
    //    // Создаем новый делегат и передаем ссылку на него в метод Table
    //    Console.WriteLine("Таблица функции MyFunc:");
    //    // Параметры метода и тип возвращаемого значения, должны совпадать с делегатом
    //    Table(new Fun(MyFunc), -2, 2);
    //    Console.WriteLine("Еще раз та же таблица, но вызов организован по новому");
    //    // Упрощение(c C# 2.0).Делегат создается автоматически.
    //    Table(MyFunc, -2, 2);
    //    Console.WriteLine("Таблица функции Sin:");
    //    Table(Math.Sin, -2, 2); // Можно передавать уже созданные методы
    //    Console.WriteLine("Таблица функции x^2:");
    //    // Упрощение(с C# 2.0). Использование анонимного метода
    //    Table(delegate (double x) { return x * x; }, 0, 3);
    //    Console.ReadLine();


    //}

}
}
