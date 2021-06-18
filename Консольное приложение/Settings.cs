using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Settings
    {
        private bool cycle = true;

        public void Option()
        {
            Console.Clear();
            Console.WriteLine("Выберите команду\n(1)Задний фон\n(2)Текст\n(3)Назад");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Background();
            }

            if (choice == 2)
            {
                TextColor();
            }

            if (choice == 3)
            {
                Console.Clear();
                MainMenu back = new MainMenu();
                back.Menu();
            }
        }

        #region Задний фон
        private void Background()
        {
            while(cycle != false)
            {
                Console.Clear();
                Console.WriteLine("Выберите цвет заднего фона\n(1)Белый\n(2)Черный\n(3)Зеленый\n(4)Синий\n(5)Красный\n(6)Назад");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                }

                if (choice == 2)
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                if (choice == 3)
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                }

                if (choice == 4)
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                }

                if (choice == 5)
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                }

                if (choice == 6)
                {
                    Option();
                }
                else
                {
                    Console.WriteLine("Выберите предоставленную команду");
                }
            }
            
        }
        #endregion

        private void TextColor()
        {
            while (cycle != false)
            {
                Console.Clear();
                Console.WriteLine("Выберите цвет текста\n(1)Белый\n(2)Черный\n(3)Зеленый\n(4)Синий\n(5)Красный\n(6)Назад");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                }

                if (choice == 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Black;
                }

                if (choice == 3)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                }

                if (choice == 4)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                }

                if (choice == 5)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }

                if (choice == 6)
                {
                    Option();
                }
                else
                {
                    Console.WriteLine("Выберите предоставленную команду");
                }
            }
            
        }
    }
    }
