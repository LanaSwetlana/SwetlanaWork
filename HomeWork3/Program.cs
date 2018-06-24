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

    //Вычитание //
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
    public Complex Multi(Complex x)
    {
        Complex y;
        y.au = au * x.au + bu * x.au;
        y.bu = bu * x.bu + au * x.bu;
        return y;
    }
    public string ToString()
    {
        return au + "+" + bu + "i";
    }
}
class ComplexCL
{//2.б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверитьработу класса;//
    public double au;
    public double bu;
    //Вычитание //
    public ComplexCL Minus(ComplexCL X2)
    {
        ComplexCL X3 = new ComplexCL();
        X3.au = this.au - X2.au;
        X3.bu = this.bu - X2.bu;
        return X3;

    }
    //Произведение //
    public ComplexCL Multy(ComplexCL X2)
    {
        ComplexCL X3 = new ComplexCL();
        X3.au = this.au * X2.au + X2.au * this.bu;
        X3.bu = this.bu * X2.bu + X2.bu * this.au;
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


        static void Main(string[] args)

        {//1.а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.
         //Продемонстрировать работу структуры;

            Complex complex1;
            complex1.au = 44;
            complex1.bu = 32;

            Complex complex2;
            complex2.au = 5;
            complex2.bu = 10;

            Complex result = complex1.Minus(complex2);
            Console.WriteLine(result.ToString());

            result = complex1.Plus(complex2);
            Console.WriteLine(result.ToString());

            result = complex1.Multi(complex2);
            Console.WriteLine(result.ToString());

            //2.б) Дописать класс Complex, добавив методы вычитания и произведения чисел.//
            //Проверитьработу класса;//

            ComplexCL complex3 = new ComplexCL();
            complex3.au = 44;
            complex3.bu = 32;

            ComplexCL complex4 = new ComplexCL();
            complex4.au = 5;
            complex4.bu = 10;

            ComplexCL result1 = complex3.Minus(complex4);
            Console.WriteLine(result1.ToString());

            ComplexCL result2 = complex3.Multy(complex4);
            Console.WriteLine(result2.ToString());

            ComplexCL result3 = complex3.Plus(complex4);
            Console.WriteLine(result3.ToString());



            //-----------------------------------------------------------------------



            Number23();
            //Fractionn();




        }


        static void Number23()
        {
            //        {//а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке).
            //         //Требуется подсчитать сумму всех нечетных положительных чисел.Сами числа и сумму
            //         //вывести на экран; Используя tryParse;//
            //         //tryParse защита от дурака//
            //         //б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные
            //         //данные.При возникновении ошибки вывести сообщение.
            //         //Напишите соответствующую функцию


            int b, summ;
            string a, v;
            v = "chislo";
            bool flag;
            summ = 0;

            do
            {
                Console.WriteLine("Введите число. Подсчет будет вестись пока не введете 0");
                a = Console.ReadLine();

                flag = int.TryParse(a, out b);


                if (b > 0 & b % 2 != 0)
                {

                    summ = summ + b;
                    v = v + " " + a;
                }
            }

            while (flag & b != 0);
            {
                if (!flag)
                {
                    Console.WriteLine("Некорректное число. Напишите соответствующую функцию");
                    Console.WriteLine("Сумма нечетных положительных чисел, введенных вами ранее =" + summ);
                    Console.WriteLine("Перечисленные вами числа" + v);
                    Console.ReadLine();
                    Number23();

                }

                if (b == 0)
                {

                    Console.WriteLine("Сумма нечетных положительных чисел =" + summ);
                    Console.WriteLine("Перечисленные вами числа " + v);
                    Console.Read();


                }
            }

        }
    }
    class Fraction
    {
        //3. * Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел.
        // Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать
        // программу, демонстрирующую все разработанные элементы класса. 
        //** Добавить упрощение дробей.

        public double a1;
        public double b1;
        public double c1;
        public double d1;
        //public double v;
        double v;

        //Сумма//
        public Fraction Summ(Fraction X2)
        {
            Fraction X3 = new Fraction();

            X3.a1 = (this.a1 * this.d1) + (this.b1 * this.c1);
            X3.b1 = this.b1 * this.d1;
            X3.v = (X3.a1 / X3.b1);
            return X3;
        }

        //Вычитание//
        public Fraction Minus(Fraction X2)
        {
            Fraction X3 = new Fraction();
            X3.a1 = (this.a1 * this.d1) - (this.b1 * this.c1);
            X3.b1 = this.b1 * this.d1;
            X3.v = (X3.a1 / X3.b1);
            return X3;
        }

        //Умножение//
        public Fraction Mult(Fraction X2)
        {
            Fraction X3 = new Fraction();
            X3.a1 = this.a1 * this.c1;
            X3.b1 = this.b1 * this.d1;
            X3.v = (X3.a1 / X3.b1);
            return X3;
        }

        //Деление//
        public Fraction Div(Fraction X2)
        {
            Fraction X3 = new Fraction();
            X3.a1 = this.a1 * this.d1;
            X3.b1 = this.c1 * this.b1;
            X3.v = (X3.a1 / X3.b1);
            return X3;

        }

        public String ToString()
        {

            return a1 + "/" + b1 + " (" + v + ") ";
        }


        //static void Main1(string[] args)
        static void Fractionn()
        {
            Fraction complex = new Fraction();
            complex.a1 = 1;
            complex.b1 = 5;
            complex.c1 = 3;
            complex.d1 = 3;

            Fraction result1 = complex.Summ(complex);
            Console.WriteLine(result1.ToString());

            Fraction result2 = complex.Minus(complex);
            Console.WriteLine(result2.ToString());


            Fraction result3 = complex.Mult(complex);
            Console.WriteLine(result3.ToString());


            Fraction result4 = complex.Div(complex);
            Console.WriteLine(result4.ToString());
            Console.Read();
        }




    }
}




