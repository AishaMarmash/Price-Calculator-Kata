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
            Configurations.CurrencyType = CurrencyTypes.USD;
            Configurations.TaxPercentage = 20;
            Configurations.CapValue = "0";

            //create product
            Product product = new(productName, productUpc, productPrice);
            //add it to products' list
            _products.Add(product);
            //we can add others

            UniversalDiscountCalculator.DiscountPercentage = 0;
            UniversalDiscountCalculator.When = DiscountTime.after;

            UPCDiscountRegistration register = ServicesProvider.CreateUPCDiscountRegistration();
            register.SetDiscountPercentage(_products, 12345, 0, DiscountTime.after);

            ExpensesRegister expensesRegester = ServicesProvider.CreateExpensesRegister(ref product);
            //expensesRegester.Add("Transport", "3%");
            //expensesRegester.Add("Packagig", "1%");

            PriceCalculator priceCalculator = ServicesProvider.CreatePriceCalculator();
            priceCalculator.DiscountType = DiscountTypes.additave;

            product.CurrentPrice = priceCalculator.CalculatePrice(product);
            ReportsManager report = ServicesProvider.CreateReportsManager();

            foreach (var pro in _products)
            {
                var reportValue = report.PrepairingReport(pro, priceCalculator);
                Console.WriteLine(reportValue);
            }
        }
    }
}