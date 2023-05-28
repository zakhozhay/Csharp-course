using System;

namespace Circles
{
    class CirclesProgram
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; //Переключення консолі на використання UTF8 кодування

            //----------------------------------- Використання циклу for ----------------------------------
            char symbol;
            for (int code = 0; code <= 255; code++)
            {
                symbol = (char)code;
                Console.WriteLine("code = " + code.ToString() + "     symbol = " + symbol.ToString());
            }
            //--------------------------------------------------------------------------------------
            //--------------------------------- Використання циклу while ----------------------------------
            int result = 0; // Якщо це значення встановити одразу 4, то жодного разу цикл не буде виконаний.
            Console.WriteLine("Скільки буде 2 + 2 ?");
            while (result != 4)
            {
                result = int.Parse(Console.ReadLine());
            }
            //--------------------------------------------------------------------------------------
            //--------------------------------- Використання циклу do while ----------------------------------
            result = 4;
            Console.WriteLine("Скільки буде 2 + 2 ?");
            do
            {
                result = int.Parse(Console.ReadLine());
            }
            while (result != 4); // початкове значення result до циклу 4, але перевірка тільки наприкінці циклу
                                 // тому цей приклад працює як і попередній.
        }
    }
}
