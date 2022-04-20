using Price_Calculator_Kata.Models;
using Price_Calculator_Kata.Services;

namespace Price_Calculator_Kata
{
    internal class Program
    {
        private static List<Product>? _products;
        public static void Main()
        {
            _products = new List<Product>();
            var productName = "The Little Prince";
            var productUpc = 12345;
            double productPrice = 20.25;
            Currency.Type = CurrencyTypes.USD;
            Tax.TaxPercentage = 21;

            Product product = new(productName, productUpc, productPrice);
            _products.Add(product);

            UniversalDiscountCalculator.DiscountPercentage = 15;
            UniversalDiscountCalculator.When = DiscountTime.after;

            UPCDiscountRegistration register = new UPCDiscountRegistration();
            register.SetDiscountPercentage(_products, 12345, 7, DiscountTime.after);

            ExpensesRegister expensesRegester = new(ref product);
            //expensesRegester.Add("Transport", "3%");
            //expensesRegester.Add("Packagig", "1%");

            PriceCalculator priceCalculator = new();
            priceCalculator.DiscountType = DiscountTypes.additave;

            Cap.CapValue = "20%";

            product.CurrentPrice = priceCalculator.CalculatePrice(product);
            ReportsManager report = new(); 

            foreach (var pro in _products)
            {
                var reportValue = report.PrepairingReport(pro, priceCalculator);

                Console.WriteLine(reportValue);
            }
        }
    }
}