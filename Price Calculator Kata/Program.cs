using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Calculator_Kata
{
    internal class Program
    {
       public static void Main()
       {
            Product.Tax = 21;
            Product product = new Product("The Little Prince",12345,20.25);
            Console.WriteLine(product.ProductPriceInformation());
       }

    }
}
