using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Calculator_Kata
{
    internal class Report
    {
        static string? report;
        public static string? PrintReport(List<Product> products)
        {
            foreach(var product in products)
            {
                report += $"price ${product.CurrentPrice:0.00}{Environment.NewLine}" +
                          $"{((Discount._discountValue==0) ? " " : $"${Discount._discountAmount:0.00} amount which was deduced")}";
            }
            return report;
        }
    }
}
