using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_3
{
    public class DeliverService
    {
        public bool PlaceOrder(Product product)
        {
            if (product.Stock>0)
            {
                return false;
            }
            else
            {
                throw new ProductOutOfStockException();
            }
        }

    }
}
