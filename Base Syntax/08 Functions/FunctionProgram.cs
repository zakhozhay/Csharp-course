using System;
using System.Text;

namespace _8_Functions
{
    class FunctionProgram
    {
        //реалізация методу, що не повертає значення
        public static void myFunction1(String line)
        {
            Console.WriteLine(line);
        }

        //реалізація методу, що повертає значення
        public static int myFunction2(int[] mass)
        {
            int summa = 0;
            for (int i = 0; i < mass.Length; i++)
                summa += mass[i];

            return summa;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; //Переключення консолі на використання UTF8 кодування

            myFunction1("Приклад виведення стрічки, яка передаєтся до методу"); // приклад виклику методу, що не повертає значення

            int[] massive = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("\nСума елементів масиву, що розрахована в методі: " + myFunction2(massive)); // приклад виклику методу, що повертає значення
        }
    }
}
