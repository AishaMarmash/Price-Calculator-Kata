using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Calculator_Kata
{
    internal class Program
    {
        private static readonly List<Product> _products = new();
        public static void Main()
        {
            var productName = "The Little Prince";
            var productUpc = 12345;
            double productPrice = 20.25;
            Currency.Type = CurrencyTypes.USD;

            Product product = new(productName, productUpc, productPrice);
            _products.Add(product);
            
            Tax.TaxPercentage = 21;
            
            UniversalDiscount.DiscountPercentage = 15;
            UniversalDiscount.When = DiscountTime.after;
            
            UPCDiscount.SetDiscountPercentage(_products, 12345, 7);
            UPCDiscount.When = DiscountTime.after;
            
            Expenses expences = new(product);
            Expenses.Add("Transport","3%");
            Expenses.Add("Packagig","1%");
            
            Price.DiscountType = DiscountTypes.additave;
            
            Cap.CapValue = "4";
            
            product.CurrentPrice = Price.CalculatePrice(product);
            Report.PrintReport(_products);
        }
    }
}