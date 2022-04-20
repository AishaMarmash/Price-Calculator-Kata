namespace Price_Calculator_Kata.Services
{
    public class TaxCalculator
    {
        double _taxAmount;
        public double Calculate(Product product)
        {
            _taxAmount = product.CurrentPrice * (Configurations.TaxPercentage / 100.0);
            return Math.Round(_taxAmount, 4);
        }
    }
}