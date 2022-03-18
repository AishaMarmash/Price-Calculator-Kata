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
        public static double CalculateTax(Product product)
        {
            double taxAmount;
            taxAmount = product.CurrentPrice * (_taxPercentage / 100.0);
            return Math.Round(taxAmount,2);
        }
    }
}