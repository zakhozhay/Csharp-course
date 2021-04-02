using System;
using System.Text; //необхідна для використання класу Encoding в якому задається кодування

namespace Branching
{
    class BranchingProgram
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; //Переключення консолы на використання UTF8 кодування

            //----------------------------------- Використання оператору if else ----------------------------------
            Console.WriteLine("Введіть бал: ");
            int score = int.Parse(Console.ReadLine());
            if (score >= 0 && score <= 23) Console.WriteLine("Це оцінка F");
            else if (score >= 24 && score <= 59) Console.WriteLine("Це оцінка Fx");
                 else if (score >= 60 && score <= 63) Console.WriteLine("Це оцінка E");
                      else if (score >= 64 && score <= 73) Console.WriteLine("Це оцінка D");
                           else if (score >= 74 && score <= 81) Console.WriteLine("Це оцінка C");
                                else if (score >= 82 && score <= 90) Console.WriteLine("Це оцінка B");
                                     else if (score >= 91 && score <= 100) Console.WriteLine("Це оцінка A");
                                          else Console.WriteLine("Помилка!!!");
            //--------------------------------------------------------------------------------------
            //----------------------------------- Використання оператору switch case ----------------------------------
            Console.WriteLine("Відповідіть на таке питання: В якому році сталася Ледове побоїще?\n" +
                             " Виберіть номер відповіді: 1 - 1240  2 - 1241  3 - 1242");
            //--------------------------------------------------------------------------------------
            switch (Console.ReadLine())
            {
                case "1": Console.WriteLine("Помилка!!!"); break;
                case "2": Console.WriteLine("Помилка!!!"); break;
                case "3": Console.WriteLine("Правильно!!! Добре вивчав історію!"); break;
                default: Console.WriteLine("Такого варіанту відповіді не було!!!"); break;
            }
        }
    }
}
