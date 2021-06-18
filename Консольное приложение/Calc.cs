using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Calc
    {
        private double num1;
        private double num2;
        private double res;


        public void CalcChoose()
        {
            #region Выбор операции.
            Console.Clear();
            Console.WriteLine("Выберите операцию\n(1) Плюс+\n(2) Минус-\n(3) Разделение\n(4) Умножение*\n(5) Назад");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Plus();
            }
            if (choice == 2)
            {
                Minus();
            }
            if (choice == 3)
            {
                Division();
            }
            if (choice == 4)
            {
                Multi();
            }
            if (choice == 5)
            {
                MainMenu back = new MainMenu();
                back.Menu();
            }
            else
            {
                Console.WriteLine("Выберите из того что имеется");
                Console.ReadLine();
                CalcChoose();
            }
            #endregion
        }

        // Штука в котором вводятся два числа
        private void Operation()
        {
            Console.Clear();
            Console.WriteLine("Введите первое число");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Введите первое число");
            num2 = Convert.ToDouble(Console.ReadLine());
        }


        // Штука которая возвращает назад 
        private void Back()
        {
            Console.Clear();
            Console.WriteLine("Нажмите чтобы вернуться");
            Console.ReadLine();
            CalcChoose();
        }

        private void Plus()
        {
            #region Сложение.
            Operation();
            Console.Clear();

            res = num1 + num2;
            Console.WriteLine("Решение:");
            Console.WriteLine($"{num1} + {num2} = {res}");
            Console.ReadLine();
            Back(); 
            #endregion
        }

        private void Minus()
        {
            #region Вычитание.
            Operation();
            res = num1 - num2;
            Console.WriteLine("Решение:");
            Console.WriteLine($"{num1} - {num2} = {res}");
            Console.ReadLine();
            Back();
            #endregion 
        }

        private void Multi()
        {
            #region Умножение.
            Operation();
            Console.Clear();

            res = num1 * num2;
            Console.WriteLine("Решение:");
            Console.WriteLine($"{num1} * {num2} = {res}");
            Console.ReadLine();
            Back();
            #endregion
        }

        private void Division()
        {
            #region Деление.
            Operation();

            Console.Clear();
            res = num1 / num2;
            Console.WriteLine("Решение:");
            Console.WriteLine($"{num1} / {num2} = {res}");
            Console.ReadLine();
            Back();
            #endregion
        }
    }
}
