using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_Homework_1
{
    struct Complex
    {
        double im;
        double re;

        public Complex Plus(Complex x2)

            //Сложение комлексных чисел
          
        {
            Complex x3 = new Complex();
            x3.im = x2.im + this.im;
            x3.re = x2.re + this.re;
            return x3;
        }

        public string Plus()

        {
            return $"{re} + {im}i";
        }
        //Вычитание комплексных чисел
        public Complex Minus(Complex x4)
        {
            Complex x5 = new Complex();
            x5.im = x4.im - this.im;
            x5.re = x4.re - this.re;
            return x5;
        }

        public string Minus()
        {
            return $"{re} - {im}i";
        }

        //Произведение комплексных чисел

        public Complex Multiplication(Complex x6)
        {
            Complex x7 = new Complex();
            x7.im = x6.im * this.re + x6.re * this.im;
            x7.re = x6.re * this.re - this.im * x6.im;
            return x7;
        }

        public string Multiplication()
        {
            return $"{re} * {im}i";
        }
    }

   

    class Program
    {
        static void Main(string[] args)
        {
            //Метод сложения комплексных чисел

            Complex complex1 = new Complex();
            complex1.re = 1;
            complex1.im = 1;

            Complex complex2 = new Complex();
            complex2.re = 2;
            complex2.im = 2;

            Complex result = complex1.Plus(complex2);
            Console.WriteLine(result.Plus());

            //Метод вычитания комплексныхх чисел

            Complex complex3 = new Complex();
            complex3.re = 3;
            complex3.im = 3;

            Complex complex4 = new Complex();
            complex4.re = 4;
            complex4.im = 4;

            Complex result2 = complex3.Minus(complex4);
            Console.WriteLine(result2.Minus());

            //Метод произведения комплексных чисел

            Complex complex5 = new Complex();
            complex5.re = 5;
            complex5.im = 5;

            Complex complex6 = new Complex();
            complex6.re = 6;
            complex6.re = 6;

            Complex result3 = complex5.Multiplication(complex6);
            Console.WriteLine(result3.Multiplication());

            
        }
    }

}