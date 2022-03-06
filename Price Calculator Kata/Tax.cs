using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Calculator_Kata
{
    class Tax
    {
        public static int _taxPercentage = 20;
        public static void ApplyTax(List<Product> products)
        {
            double taxAmount;
            foreach(var product in products)
            {
                taxAmount = product.BasePrice * (_taxPercentage / 100.0);
                product.CurrentPrice += taxAmount;
            }
        }
    }
}