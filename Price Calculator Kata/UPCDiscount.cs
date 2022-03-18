using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Calculator_Kata
{
    internal class UPCDiscount
    {
        public static int _upcDiscount = 0;
        public static double _discountAmount;
        public static string when = "after";

        public static void setUpcDiscountPercentage(List<Product> products, int upcValue, int discountPercentage)
        {
            var query = products.Where(n => n.UPC == upcValue).Select(n => n).ToList();
            foreach (var product in query)
            {
                product.UPCDiscount = discountPercentage;
            }
        }
        public static double CalculateUpcDiscount(Product product)
        {
            _discountAmount = product.CurrentPrice * (product.UPCDiscount / 100.0);
            return _discountAmount;
        }

    }
}
