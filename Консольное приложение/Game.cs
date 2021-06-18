using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class What
    {
        public void Something()
        {
          
            Console.Clear();
            Console.WriteLine("Введите что нибудь\n(1035)НАЗАД\n(56)Игра");
            string str = Console.ReadLine();
            int count = str.Length;

            if (str == "1035")
            {
                MainMenu back = new MainMenu();
                back.Menu();
            }

            if (count < 10)
            {
                Console.Clear();
                int sum = str.Length * 10;
                Console.WriteLine($"Вы написали стоко слов: {str.Length} а значит получаете {sum} xp");
                Console.ReadLine();
                Something();
            }

            if(count > 10)
            {
                int i = 0;
                while (i < 10)
                {
                    i++;
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Something();
            }
        }
    }
}
