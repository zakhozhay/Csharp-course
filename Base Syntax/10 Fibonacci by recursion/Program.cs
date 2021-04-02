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
            Console.WriteLine("Виклик функції FibonacciNumber(" + x + ") ...");
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
            Console.WriteLine("Результат виклика функції FibonacciNumber(" + x + ") дорівнює " + result);
            return result;
        }

        static void Main(string[] args)
        {
                Console.OutputEncoding = Encoding.UTF8; //Переключення консолы на використання UTF8 кодування
                int n; //змінна порядкового номеру числа Фібоначчі
                int number; //Значення числа Фібоначчі
         begin: Console.Clear();
                Console.Write("Введіть порядковий номер числа Фібоначчі: ");
                n=int.Parse(Console.ReadLine());
                number = FibonacciNumber(n);
                Console.WriteLine(n + "-е число Фібоначчі дорівнює " + number);
         error: Console.Write("Повторити? (y/n):");
                string result = Console.ReadLine();
                if (result == "y") goto begin;
                if (result != "n" && result != "y")
                {
                    Console.WriteLine("Помилка!");
                    goto error;
                }

        }
    }
}
