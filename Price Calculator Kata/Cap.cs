using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Calculator_Kata
{
    internal class Cap
    {
        public static string CapValue = "";
        public static void ApplyCap(Product product)
        {
            double capValue = parseCap(CapValue, product);
            if(Price.TotalDiscount > capValue )
            {
                Price.TotalDiscount = capValue;
                product.CurrentPrice = product.BasePrice - capValue;
            }
        }
        private static double parseCap(string value, Product product)
        {
            double capValue;
            double capPercentage;
            if (value.Contains("%"))
            {
                int indexOfPercent = value.IndexOf('%');
                value = value.Remove(indexOfPercent);
                capPercentage = (double.Parse(value) / 100);
                capValue = CalculateCap(capPercentage, product);
            }
            else
            {
                capValue = double.Parse(value);
            }
            return Math.Round(capValue, 2);
        }
        public static double CalculateCap(double Amount,Product product)
        {
            return Math.Round(Amount * (product.BasePrice - Price.PreTaxDiscount), 4);
        }
    }
}
