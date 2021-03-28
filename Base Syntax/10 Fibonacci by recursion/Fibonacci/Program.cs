using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static int FibonacciNumber(int x)
        {
            Console.WriteLine("Вызов функции FibonacciNumber(" + x + ") ...");
            int fibonacci1, fibonacci2, result;
            if (x < 3)
            {
                result = 1;
            }
            else
            {
               fibonacci1 = FibonacciNumber(x - 1);
               fibonacci2 = FibonacciNumber(x - 2);
               result = fibonacci1 + fibonacci2;
            }
            Console.WriteLine("Результат вызова функции FibonacciNumber(" + x + ") равно " + result);
            return result;
        }

        static void Main(string[] args)
        {
                int n; //переменная порядкового номера числа Фибоначчи
                int number; //Значение числа Фибоначчи
        begin: Console.Clear();
                Console.Write("Введите порядковый номер числа Фибоначчи: ");
                n=int.Parse(Console.ReadLine());
                number = FibonacciNumber(n);
                Console.WriteLine(n + "-е число Фибоначчи равно " + number);
            error: Console.Write("Повторить? (y/n):");
                string result = Console.ReadLine();
                if (result == "y") goto begin;
                if (result != "n" && result != "y")
                {
                    Console.WriteLine("Ошибка!");
                    goto error;
                }

        }
    }
}
