using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    class TypesProgram
    {
        static void Main(string[] args)
        {
            //----------------------------------- Об'ява змінних ----------------------------------
            int a = 10;
            float b = 3.2F; //За замовченням у C# використовується тип double.
                            //Для примусового позначення як float - ставиться індекс F
            double c = 1.2e-4;
            char d = 's';
            string e = "Line of characters";
            bool f = true;
            //--------------------------------------------------------------------------------------
            //--------------------------------- Виведенння типів ----------------------------------
            var name = "Ivan Ivanov";
            var age = 18;
            var student_status = true;

            Type Tname = name.GetType();
            Type Tage = age.GetType();
            Type Tstudent_status = student_status.GetType();
            
            Console.WriteLine("Виведений тип даних для name: " + Tname.ToString());
            Console.WriteLine("Виведений тип даних для age: " + Tage.ToString());
            Console.WriteLine("Виведений тип даних для student_status: " + Tstudent_status.ToString());
            //-------------------------------------------------------------------------------------
            //------------------------------- Перетворення типів ----------------------------------

            //Неявне перетворення

            int var_int = 10;
            long var_long = var_int;

            float var_float = 3.7F; //так як за умовчанням обробляється значення як double
            double var_double = var_float;
            Console.Write("var_float = "); Console.WriteLine(var_float);
            Console.Write("var_double= "); Console.WriteLine(var_double); //зверніть увагу на різні значення при цих виводах!

            //Явне перетворення

            var_int = (int)var_float;
            var_float = (float)var_int;

            string var_string = "123"; //якщо число завдане строкою символів
            var_int = int.Parse(var_string); //перший варіант перетворення
            var_int = Convert.ToInt32(var_string); //другий варіант перетворення (int32 це фактично int)

            var_string = var_int.ToString(); //представлення даних до строкового типу
            //-------------------------------------------------------------------------------------
            Console.ReadKey();
        }
    }
}