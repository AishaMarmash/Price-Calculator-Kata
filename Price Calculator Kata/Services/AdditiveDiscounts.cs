using Price_Calculator_Kata.Models;

namespace Price_Calculator_Kata
{
    public class AdditiveDiscounts : Discount, IDiscountTime
    {
        public override double CalcPreTaxDiscounts(Product product)
        {
            _discount = 0;
            if (UniversalDiscountCalculator.When == DiscountTime.before)
            {
                _discount += universalDiscount.Calculate(product);
            }
            if (product.UPCDiscountTime == DiscountTime.before)
            {
                _discount += uPCDiscount.Calculate(product);
            }
            product.CurrentPrice -= Math.Round(_discount, 4);
            return Math.Round(_discount, 4);
        }
        public override double CalcAfterTaxDiscounts(Product product)
        {
            _discount = 0;
            if (UniversalDiscountCalculator.When == DiscountTime.after)
            {
                _discount += universalDiscount.Calculate(product);
            }
            if (product.UPCDiscountTime == DiscountTime.after)
            {
                _discount += uPCDiscount.Calculate(product);
            }
            product.CurrentPrice -= Math.Round(_discount, 4);
            return Math.Round(_discount, 4);
        }
    }
}