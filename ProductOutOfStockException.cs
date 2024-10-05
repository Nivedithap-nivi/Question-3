using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_3
{
    public class ProductOutOfStockException : Exception
    {
        public override string Message => "Product is out of stock";
    }
}
