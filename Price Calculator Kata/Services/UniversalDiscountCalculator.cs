using Price_Calculator_Kata.Models;

namespace Price_Calculator_Kata
{
    public class UniversalDiscountCalculator : IDiscountManager
    {
        public static int DiscountPercentage = 15;
        public double DiscountAmount;
        public static DiscountTime When = DiscountTime.after;
        public double Calculate(Product product)
        {
            DiscountAmount = product.CurrentPrice * (DiscountPercentage / 100.0);
            return Math.Round(DiscountAmount, 4);
        }
    }
}