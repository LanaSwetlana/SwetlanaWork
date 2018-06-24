using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace HomeWork6
{
    delegate double Dubtask3(double x, double x2);

    //    Подсчитать количество студентов:
    //а) учащихся на 5 и 6 курсах;
    //б)* подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(частотный
    // массив);
    //в) отсортировать список по возрасту студента;
    //г) ** отсортировать список по курсу и возрасту студента.

    class Student
    {      
        public string firstName;
        public string surname;
        public string univercity;
        public string faculty;        
        public string department;             
        public int age;
        public int group;
        public int course;
        public string city;

        //Создаем контруктор
        public Student(string firstName, string surname, string univercity, string faculty, string department, int age , int course, int group, string city)
        {
            this.firstName = firstName;
            this.surname = surname;
            this.univercity = univercity;
            this.faculty = faculty;
            this.department = department;
            this.course = course;
            this.age = age;
            this.group = group;
            this.city = city;
        }

        //в) отсортировать список по возрасту студента;

        static int MyDelegat(Student st1, Student st2) // Создаем метод для сравнения для экземпляров
        {
            return String.Compare(st1.age.ToString(), st2.age.ToString());

        }

        //г) ** отсортировать список по курсу и возрасту студента.

        static int MyDelegat1(Student st1, Student st2) 
        {

           int res = String.Compare(st1.age.ToString(), st2.age.ToString());
            if (res == 0)
                return String.Compare(st1.course.ToString(), st2.course.ToString());
            else return res;
        }

       
        // Выводим в алфавитном порядке

        static int MyDelegat2 (Student st1, Student st2) //Создаем метод для сравнения для экземпляров
        {
            int res = String.Compare(st1.firstName, st2.firstName); // Сравниваем две строки
            if (res == 0) return String.Compare(st1.surname, st2.surname);
            else return res;

        }

        public static void Kurs()
        {
            int kurs5=0;
            int kurs6=0;
            int r1 = 0;
            int r2 = 0;
            int r3 = 0;
            int r4 = 0;
            int r5 = 0;
            int r6 = 0;

            //Обобщеный список студентов
            List<Student> students = new List<Student>();

            DateTime dt = DateTime.Now;

            //Создаем поток данных на чтение            
            //Автоматически путь в папке, где файл запустился
            StreamReader sr = new StreamReader("Студенты.csv");

                Student t;
            
                string temp = "";
                string[]s;
                while(!sr.EndOfStream)   //как толко конец потока
                {
                    try
                    {
                        temp = sr.ReadLine();
                        s = temp.Split(';');
                        //Добавляем в список новый экземпляр класса Student
                        t = new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5] ), int.Parse(s[6]), int.Parse(s[7]), s[8] /*FirstName, Surname, univesity, faculty, department,age,course,city*/);
                        students.Add(t);
                    //students.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8] ));

                    //а) учащихся на 5 и 6 курсах;
                    if (int.Parse(s[6]) == 5) kurs5++;
                    if (int.Parse(s[6]) == 6) kurs6++;

                    //б)*подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(частотный массив);
                    if (int.Parse(s[5]) >= 18 && int.Parse(s[5]) <= 22) 
                    {
                        
                        if ((int.Parse(s[6]) == 1)) r1++;
                        if ((int.Parse(s[6]) == 2)) r2++;
                        if ((int.Parse(s[6]) == 3)) r3++;
                        if ((int.Parse(s[6]) == 4)) r4++;
                        if ((int.Parse(s[6]) == 5)) r5++;
                        if ((int.Parse(s[6]) == 6)) r6++;
                        
                    }

                }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                        // Выход из Kurs
                        if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                    }
                }

           
            sr.Close();

            students.Sort(new Comparison<Student>(MyDelegat));

            Console.WriteLine("Всего студентов:" + students.Count);
            Console.WriteLine("Студентов 5 курса:{0}", kurs5);
            Console.WriteLine("Студентов 6 курса:{0}", kurs6);

            Console.WriteLine("Студентов от 18 до 20 лет: на первом курсе {0},на втором курсе {1},на третьем курсе {2},на четвертом курсе {3},на пятом курсе {4},на шестом курсе {5}", r1,r2,r3,r4,r5,r6);

            //выведет возраст
            foreach (var v in students) Console.WriteLine(v.age);

            // По возрасту и курсу
            students.Sort(MyDelegat1);

            foreach (Student v in students) Console.WriteLine(v.ToString());

           //Алфавитный порядок
            foreach (Student v in students) Console.WriteLine(v.ToString());

            students.Sort(new Comparison<Student>(MyDelegat1));
            foreach (var v in students) Console.WriteLine(v.course);                                                        
          
            Console.WriteLine(DateTime.Now - dt);
            Console.ReadLine();

        }        
           
    }

}
