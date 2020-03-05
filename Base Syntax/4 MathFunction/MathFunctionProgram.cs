using System;

namespace ConsoleApp1
{
    class MathFunctionProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приклад використання функції pow(2,3) 2 в ступені 3. Результат: {0}", Math.Pow(2, 3));
            /*Математичні функції є методами класа Math, який, в сво. чергу, є елементом простору імен System.
              Тому для їх використання треба вказати using System, а звертатися до функцій: Math.<им'я функції>.
            */
        }
    }
}
