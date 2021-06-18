using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Второе_консольное_приложение
{
    public class ProductNameException : Exception
    {
        public ProductNameException() : base("Название продукта не должно быть пустым! или слишком длинным") { }
        public ProductNameException(string msg) : base(msg) { }
    }

    public class ProductPriceException : Exception
    {
        public ProductPriceException() : base("Цена не должна быть пустым ниже нуля и выше 100 000") { }
        public ProductPriceException(string msg) : base(msg) { }
    }

}
