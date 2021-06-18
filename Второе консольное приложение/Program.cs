using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Второе_консольное_приложение
{
    class Program
    {
        static void Main(string[] args)
        {

            Main next = new Main();
            next.MainFace();
        }
    }

    class Main
    {
        public void MainFace()
        {
            Console.Clear();
            Console.WriteLine("Выберите действие\n(1)Добавить товар\n(2)Посмотреть товар\n(3)Поиск слова\n(4)Выйти");
            sbyte choice = sbyte.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ProductAdd add = new ProductAdd();
                    break;
                case 2:
                    ProductRead read = new ProductRead();
                    break;
                case 3:
                    ProductDelete delete = new ProductDelete();
                    break;
                case 4:
                    Console.WriteLine("Нажмите чтобы выйти");
                    Console.ReadLine();
                    break;
            }
        }
    }

    public class ProductAdd
    {
        public ProductAdd() 
        {
            Console.Clear();
            Console.WriteLine("Введите название продукта");
            string name = Console.ReadLine();
          
            Console.WriteLine("Введите цену");
            int price = int.Parse(Console.ReadLine());

            Product product = new Product(name, price);

            using (var sw = new StreamWriter("Product.txt", true, Encoding.UTF8))
            {
                sw.WriteLine($"{product.Name} {product.Price}");
            }
            Console.WriteLine("Нажмите чтобы вернуться");
            Console.ReadLine();
            Main back = new Main();
            back.MainFace();
        }
    }

    public class ProductRead
    {
        public ProductRead()
        {
            Console.Clear();
            using (var sr = new StreamReader("Product.txt"))
            {
                var text = sr.ReadToEnd();
                Console.WriteLine(text);
            }
            Console.ReadLine();
            Main back = new Main();
            back.MainFace();
        }
    }

    public class ProductDelete
    {
        public ProductDelete()
        {
            Console.WriteLine("Введите имя немого очкарика с монтировкой");

            string guess = Console.ReadLine();
            if (guess == "гордон" || guess == "Гордон" || guess == "Фримен" || guess == "фримен" || guess == "Гордон Фримен")
            {
                Console.Clear();
                Console.WriteLine("Поздравляю!");
                using (var sr = new StreamReader("Meem.txt"))
                {
                    
                    string text = sr.ReadToEnd();
                    Console.WriteLine(text);
                }
            }
            else
            {
                Console.WriteLine("Не то");
            }

            Console.WriteLine("Нажмите чтобы вернуться");
            Console.ReadLine();
            Main back = new Main();
            back.MainFace();
        }
      
    }
}
