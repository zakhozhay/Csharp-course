using System;

namespace Ariphmetic
{
    class AriphmeticProgram
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; //Переключення консолі на використання UTF8 кодування

            int x1, x2;
            Console.Write("Введіть x1: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть x2: ");
            x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Сума x1 і x2 дорівнює {0}", (x1 + x2).ToString());
            Console.WriteLine("Різниця x1 і x2 дорівнює {0}", (x1 - x2).ToString());
            Console.WriteLine("Додаток x1 і x2 дорівнює {0}", (x1 * x2).ToString());
            Console.WriteLine("Діління x1 і x2 дорівнює {0}", ((double)x1 / x2).ToString()); // Зверніть увагу, що якщо діління здійснбється на цілочисельними даними, то результат не буде містити дробної састини
                                                                                             //тому перший операнд завчасно, до виконання операції представляється у вещественому форматі
            Console.WriteLine("Остаток від діління x1 і x2 дорівнює {0}", (x1 % x2).ToString());
        }
    }
}
