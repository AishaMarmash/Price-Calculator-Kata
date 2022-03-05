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
            Tax._taxValue = 20;
            Product product = new Product("The Little Prince", 12345, 20.25);
            _products.Add(product);
            Tax.ApplyTax(_products);
            foreach (var i in _products)
            {
                Console.WriteLine(i.ProductPriceInfo());
            }
        }
    }
}