using System;
using System.Text;

namespace _9_Classes
{
    public class Player
    {
        public String name;
        public byte age;
        public double force;
        public Player(byte age, double force)
        {
            this.age = age;
            this.force = force;
            this.name = this.ToString();
        }
        public Player() { }

        public void push()
        {
            force -= age / 100;
        }

        public void pass()
        {
			Console.WriteLine("Ну і навищо тоді гру запускав?)))");
        }

    }
    class ClassesProgram
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; //Переключення консолі на використання UTF8 кодування

			Random random = new Random(); //створення екземпляру класу генератору випадкових чисел
			Player user = new Player((byte)26, random.NextDouble());
			Player computer = new Player((byte)18, random.NextDouble());
			Player winner = new Player();

			Console.Write("Оберіть дію: 1 - грати, 2 - здатись  ");
			byte action = byte.Parse(Console.ReadLine());
			switch (action)
			{
				case 1:
					user.push();
					break;
				case 2:
					user.pass();
					return;
				default:
					Console.WriteLine("Невірний выбір");
					return;
			}
			double advantage = 0; /* В цьому випадку ініціалізація значеням обов'язкова, так як середовище відстежує
								     можливу помилку часу виконаня, коли виконується третя гілка при рівних силах.
								     В цій гілці відсутнє значення змінної advantage.
								     Тому, або так, або в третю гілку треба писати advantage = 0;
								     (що, звичайно, краще так, як може економити зайву команду до виконання.) */

			if (user.force > computer.force)
			{
				winner = user; advantage = user.force - computer.force;
			}
			else if (user.force < computer.force)
			{
				winner = computer;
				advantage = computer.force - user.force;
			}
			else
			{
				Console.WriteLine("Нічия");
			}
			Console.WriteLine("В цій схватці виграв " + winner.name); //Допускается получать системный идентификатор
																	  // экземпляра класаа и просто : System.out.print(winner);
			Console.WriteLine("Дані переможця: Вік: " + winner.age + ", Сила: " + winner.force + ". Перевага в силі: " + advantage);

		}
	}
    
}
