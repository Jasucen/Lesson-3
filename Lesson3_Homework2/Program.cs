using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            string number = Console.ReadLine();

            int num;
            int summ = 0;

            bool success = Int32.TryParse(number, out num);
            if (success)
            {
                Console.WriteLine("Введеные данные корректны.");   
            }
            else
            {
                Console.WriteLine("Введеные данные неккоректны!");
            }

            while (num !=0)
            {
                if (num > 0 && num % 2 == 1)
                {
                    summ = summ + num;
                } else
                {
                    break;
                }
                Console.WriteLine("Сумма всех нечетных положительных чисел: " + summ);
                
            }

        } 
    }
}
