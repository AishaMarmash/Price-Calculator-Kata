using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Calculator_Kata
{
    internal class Program
    {
        private static List<Product> _products = new List<Product>();
        public static void Main()
        {
            Tax._taxPercentage = 21;
            UniversalDiscount._universalDiscount = 0;
            UniversalDiscount.when = "after";
            Product product = new Product("The Little Prince", 12345, 20.25);
            _products.Add(product);
            UPCDiscount.setUpcDiscountPercentage(_products, 12345, 0);
            UPCDiscount.when = "after";
            Expenses expences = new Expenses(product);
            Expenses.Add("Transport","0");
            Expenses.Add("Packagig","0");
            product.CurrentPrice = Price.CalculatePrice(product);
            Console.WriteLine(ReportDiscount.PrintReport(_products));
        }
    }
}