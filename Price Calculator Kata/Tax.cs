using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Calculator_Kata
{
    class Tax
    {
        public static int _taxValue = 20;
        public static void ApplyTax(List<Product> products)
        {
            foreach(var product in products)
            {
                product.Price = product.Price + (product.Price * (_taxValue / 100.0));
            }
        }
    }
}