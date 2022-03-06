using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Calculator_Kata
{
    internal class Discount
    {
        public static int _discountValue = 15;
        public static double _discountAmount;
        public static void ApplyDiscount(List<Product> products)
        {
            foreach (var product in products)
            {
                _discountAmount = product.BasePrice * (_discountValue / 100.0);
                product.CurrentPrice -= _discountAmount;
            }
        }
    }
}