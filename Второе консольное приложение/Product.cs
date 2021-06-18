using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Второе_консольное_приложение
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Product(string name, int price)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Length > 30)
            {
                throw new ProductNameException();
            }

            if (price == 0 || price < 0 || price > 100000)
            { 
                throw new ProductPriceException();
            }

            this.Name = name;
            this.Price = price;
        }
    }
}
