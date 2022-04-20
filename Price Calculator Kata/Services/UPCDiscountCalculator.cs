using Price_Calculator_Kata.Models;

namespace Price_Calculator_Kata
{
    public class UPCDiscountCalculator : IDiscountManager
    {
        public double DiscountAmount;
        public double Calculate(Product product)
        {
            DiscountAmount = product.CurrentPrice * (product.UPCDiscount / 100.0);
            return Math.Round(DiscountAmount, 4);
        }
    }
}