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
            var productName = "The Little Prince";
            var productUpc = 12345;
            double productPrice = 20.25;
            string currancyType = "USD";
            Currancy.Type = currancyType;
            
            Product product = new Product(productName, productUpc, productPrice);
            _products.Add(product);
            
            Tax.TaxPercentage = 21;
            
            UniversalDiscount.DiscountPercentage = 15;
            UniversalDiscount.When = DiscountTime.after;
            
            UPCDiscount.setDiscountPercentage(_products, 12345, 7);
            UPCDiscount.When = DiscountTime.after;
            
            Expenses expences = new Expenses(product);
            Expenses.Add("Transport","3%");
            Expenses.Add("Packagig","1%");
            
            Price.DiscountWay = DiscountType.additave;
            
            Cap.CapValue = "30%";
            
            product.CurrentPrice = Price.CalculatePrice(product);
            Console.Write(Report.PrintReport(_products));
        }
    }
}