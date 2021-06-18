using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu menu = new MainMenu();
            menu.Menu();
        }
    }

    public class MainMenu
    {
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("Выберите то чего хотите\n(1)Настройки\n(2)Калькулятор\n(3)Чтото Нечто\n(4)Выход");
            int choice = 0;

            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Используйте предоставленные команды!");
            }

            switch (choice)
            {
                case 1:
                    Settings option = new Settings();
                    option.Option();
                    break;
                case 2:
                    Calc calc = new Calc();
                    calc.CalcChoose();
                    break;
                case 3:
                    What wot = new What();
                    wot.Something();
                    break;
            }
        }
    }
}
