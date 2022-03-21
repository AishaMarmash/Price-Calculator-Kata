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
            string cost = "20.25 USD";
            var items = cost.Split(" ");
            Currancy.Type = items[1];
            double productPrice = double.Parse(items[0]);
            Product product = new Product(productName, productUpc, productPrice);
            _products.Add(product);
            Tax.TaxPercentage = 21;
            UniversalDiscount.DiscountPercentage = 15;
            UniversalDiscount.When = "after";
            UPCDiscount.setDiscountPercentage(_products, 12345, 7);
            UPCDiscount.When = "after";
            Expenses expences = new Expenses(product);
            //Expenses.Add("Transport","3%");
           // Expenses.Add("Packagig","1%");
            Price.DiscountWay = "additave";
            Cap.CapValue = "30%";
            product.CurrentPrice = Price.CalculatePrice(product);
            Console.Write(Report.PrintReport(_products));
        }
    }
}