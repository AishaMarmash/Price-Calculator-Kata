using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Calculator_Kata
{
    internal class UniversalDiscount
    {
        public static int _universalDiscount = 15;
        public static int _upcDiscount = 0;
        public static double _discountAmount;
        public static string when = "after";
        public static double CalculateUniversalDiscount(Product product)
        {
            _discountAmount = product.CurrentPrice * (_universalDiscount / 100.0);
            return _discountAmount;
        }
    }
}
