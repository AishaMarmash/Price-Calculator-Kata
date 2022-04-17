using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Calculator_Kata
{
    internal class UniversalDiscount
    {
        public static int DiscountPercentage = 15;
        public static double DiscountAmount;
        public static DiscountTime When = DiscountTime.after;
        public static double CalculateDiscount(Product product)
        {
            DiscountAmount = product.CurrentPrice * (DiscountPercentage / 100.0);
            return Math.Round(DiscountAmount, 4);
        }
    }
}