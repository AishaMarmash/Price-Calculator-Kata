using Price_Calculator_Kata.Models;

namespace Price_Calculator_Kata.Services
{
    internal class TaxCalculator
    {
        double _taxAmount;
        public double Calculate(Product product)
        {
            _taxAmount = product.CurrentPrice * (Tax.TaxPercentage / 100.0);
            return Math.Round(_taxAmount, 4);
        }
    }
}