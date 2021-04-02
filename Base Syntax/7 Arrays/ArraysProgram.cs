using System;
using System.Text;

namespace _7_Arrays
{
    class ArraysProgram
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; //Переключення консолі на використання UTF8 кодування

            int[] massive1 = new int[] { 1, 2, 3, 4, 5 }; // приклад визначення одновимірного масива з визначеннням розмірності по кількості значень

            Console.WriteLine("Виведення масива massive1...");
            foreach (int element in massive1)
            {
                Console.WriteLine(element.ToString());
            }

            int[,] massive2 = new int[,] { { 1, 2, 3 },{ 4, 5, 6 },{ 7, 8, 9 } }; // завдання двовимірного масиву та ініціалізація його значеннями

            Console.WriteLine("\nВиведення двовимірного масиву massive2 у вигляді таблиці ...");
            for (int  row_index = 0; row_index <=2; row_index++)
            {
                for (int column_index =0; column_index <= 2; column_index++)
                {
                    Console.Write(massive2[row_index, column_index]+ " ");
                }
                Console.WriteLine();

            }
           
        }
    }
}
