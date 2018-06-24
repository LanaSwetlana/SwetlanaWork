using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Коновалова Светлана*/

struct Complex
{  //1.а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.
   //Продемонстрировать работу структуры;

    public double au;
    public double bu;

    //Вычитатние //
    public Complex Minus(Complex x)
    {
        Complex y;
        y.au = au - x.au; //действительная часть
        y.bu = bu - x.bu; //мнимая часть
        return y;
                
    }
    //Сложение//
    public Complex Plus(Complex x)    
    {
        Complex y;
        y.au = au + x.au;
        y.bu = bu + x.bu;
        return y;

    }
    //Умножение//
    public Complex Multi (Complex x)
    {
        Complex y;
        y.au = au* x.au + bu*x.au;
        y.bu = bu*x.bu + au*x.bu;
        return y;
    }
    public string ToString()
    {
    return au +"+"+ bu +"i";
    }
    }
class ComplexCL
{//2.б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверитьработу класса;//
    public double au;
    public double bu;
    //Вычитание //
    public ComplexCL Minus (ComplexCL X2)
    {
        ComplexCL X3 = new ComplexCL();
        X3.au = this.au - X2.au ;
        X3.bu = this.bu - X2.bu ;
        return X3;

    }
    //Произведение //
    public ComplexCL Multy (ComplexCL X2)
    {
        ComplexCL X3 = new ComplexCL();
        X3.au = this.au*X2.au + X2.au*this.bu;
        X3.bu = this.bu*X2.bu + X2.bu*this.au;
        return X3;

    }
    //Сложение//
    public ComplexCL Plus(ComplexCL X2)
    {
        ComplexCL X3 = new ComplexCL();
        X3.au = X2.au + this.au;
        X3.bu = X2.bu + this.bu;
        return X3;

    }
    public String ToString()
    {
        return au + "+" + bu + "i";
    }

}


namespace HomeWork3
{



    class Program
    {
        static int value;
        static string console_message = "Введите число. Подсчет будет вестись пока не введете 0";
        static int GetValue(string message)
        {
            int x;
            string s;
            bool flag;

            do
            {
                Console.WriteLine(message);
                s = Console.ReadLine();
                flag = int.TryParse(s, out x);

            }
            while (!flag);
            return x;
        }




        static void Main(string[] args)

        {//1.а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.
         // //Продемонстрировать работу структуры;

            //    Complex complex1;
            //    complex1.au = 44;
            //    complex1.bu = 32;

            //    Complex complex2;
            //    complex2.au = 5;
            //    complex2.bu = 10;

            //    Complex result = complex1.Minus(complex2);
            //    Console.WriteLine(result.ToString());

            //    result = complex1.Plus(complex2);
            //    Console.WriteLine(result.ToString());

            //    result = complex1.Multi(complex2);
            //    Console.WriteLine(result.ToString());

            //    //2.б) Дописать класс Complex, добавив методы вычитания и произведения чисел.//
            //    //Проверитьработу класса;//

            //    ComplexCL complex3 = new ComplexCL();
            //    complex3.au = 44;
            //    complex3.bu = 32;

            //    ComplexCL complex4 = new ComplexCL();
            //    complex4.au = 5;
            //    complex4.bu = 10;

            //    ComplexCL result1 = complex3.Minus(complex4);
            //    Console.WriteLine(result1.ToString());

            //    ComplexCL result2 = complex3.Multy(complex4);
            //    Console.WriteLine(result2.ToString());

            //    ComplexCL result3 = complex3.Plus(complex4);
            //    Console.WriteLine(result3.ToString());



            ////-----------------------------------------------------------------------

            //а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке).
            //Требуется подсчитать сумму всех нечетных положительных чисел.Сами числа и сумму
            //вывести на экран; Используя tryParse;//
            //tryParse защита от дурака//

            int a, summ;
            
            summ = 0;
            do
            {
                Console.WriteLine("Введите число. Подсчет будет вестись пока не введете 0");
                a = Convert.ToInt32(Console.ReadLine());

                if (a > 0 & a % 2 != 0)
                {
                    summ = summ + a;
                    
                }
            }

            while (a != 0);
            {
                if (a == 0)
                {
                    
                    Console.WriteLine("Сумма нечетных положительных чисел =" + summ);
                    Console.WriteLine("Перечисленные вами числа" + a);
                    Console.ReadLine();

                }




                Console.WriteLine(a);
                Console.ReadLine();
            }
        }
       
    }
}


//б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные
//данные.При возникновении ошибки вывести сообщение.
//Напишите соответствующую функцию
//3. * Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел.
// Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать
// программу, демонстрирующую все разработанные элементы класса.Достаточно решить 2
//задачи.Все программы сделать в одном решении.
//** Добавить упрощение дробей.
