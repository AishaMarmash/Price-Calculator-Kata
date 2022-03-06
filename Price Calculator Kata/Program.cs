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
            Tax._taxPercentage = 20;
            Discount._discountValue = 15; 
            Product product = new Product("The Little Prince", 12345, 20.25);
            _products.Add(product);
            Discount.ApplyDiscount(_products);
            Tax.ApplyTax(_products);
            Console.WriteLine(Report.PrintReport(_products));
        }
    }
}