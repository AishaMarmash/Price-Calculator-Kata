using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Calculator_Kata
{
    internal class ReportDiscount
    {
        static string? report;
        public static string? PrintReport(List<Product> products)
        {
            foreach (var product in products)
            {
                report += $"price {product.CurrentPrice}{Environment.NewLine}" +
                          $"total discount = {Price.TotalDiscount}";
            }
            return report;
        }
    }
}
