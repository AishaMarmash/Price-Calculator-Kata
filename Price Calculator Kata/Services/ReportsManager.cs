namespace Price_Calculator_Kata
{
    public class ReportsManager
    {
        string? _report;
        PriceCalculator _priceCalculator = ServicesProvider.CreatePriceCalculator();
        public string? PrepairingReport(Product product, PriceCalculator priceCalculator)
        {
            _priceCalculator = priceCalculator;
            if (product == null) return null;
            _report += GetCost(product);
            _report += GetTax();
            _report += GetDiscounts();
            _report += GetExpenses(product);
            _report += GetTotalPrice(product);
            _report += ReportTotalDiscount();
            return _report;
        }
        private static string? GetCost(Product product)
        {
            return $"Cost =  {Math.Round(product.BasePrice, 2):0.00} {Configurations.CurrencyType}{Environment.NewLine}";
        }
        private string? GetTax()
        {
            if (_priceCalculator.TaxAmount != 0)
                return $"Tax = {Math.Round(_priceCalculator.TaxAmount, 2):0.00} {Configurations.CurrencyType}{ Environment.NewLine}"; 
            else
                return null;
        }
        private string? GetDiscounts()
        {
            if (_priceCalculator.TotalDiscount != 0)
                return $"Discount = {Math.Round(_priceCalculator.TotalDiscount, 2):0.00} {Configurations.CurrencyType}{ Environment.NewLine}";
            else
                return null;
        }
        private static string? GetExpenses(Product product)
        {
            string? expenses = null;
            foreach (KeyValuePair<string, double> kvp in product.ExpensesList)
            {
                expenses += $"{kvp.Key} = {Math.Round(kvp.Value, 2):0.00} {Configurations.CurrencyType}{Environment.NewLine}";
            }
            return expenses;
        }
        private static string? GetTotalPrice(Product product)
        {
            return $"Total = {Math.Round(product.CurrentPrice,2):0.00} {Configurations.CurrencyType}{Environment.NewLine}";
        }
        private string? ReportTotalDiscount()
        {
            if (_priceCalculator.TotalDiscount != 0)
            { 
                return $"Total Discount = {Math.Round(_priceCalculator.TotalDiscount, 2):0.00} {Configurations.CurrencyType}{Environment.NewLine}"; 
            }
            else
            { 
                return "no discounts"; 
            }
        }
    }
}