using Price_Calculator_Kata.Models;
using System.Collections.Generic;
using System.Linq;
namespace Price_Calculator_Kata
{
    public class MultiplicativeDiscounts : Discount, IDiscountTime
    {
        public override double CalcPreTaxDiscounts(Product product)
        {
            _discount = 0;
            if (UniversalDiscountCalculator.When == DiscountTime.before)
            {
                ApplyUniversalDiscount(product);
            }
            if (product.UPCDiscountTime ==DiscountTime.before)
            {
                ApplyUpcDiscount(product);
            }
            return Math.Round(_discount, 4);
        }

        public override double CalcAfterTaxDiscounts(Product product)
        {
            _discount = 0;
            if (UniversalDiscountCalculator.When == DiscountTime.after)
            {
                ApplyUniversalDiscount(product);
            }
            if (product.UPCDiscountTime == DiscountTime.after)
            {
                ApplyUpcDiscount(product);
            }
            return Math.Round(_discount, 4);
        }

        public void ApplyUniversalDiscount(Product product)
        {
            double value;
            value = universalDiscount.Calculate(product);
            product.CurrentPrice -= value;
            _discount += value;
        }

        public void ApplyUpcDiscount(Product product)
        {
            double value = 0;
            value += uPCDiscount.Calculate(product);
            product.CurrentPrice -= value;
            _discount += value;
        }
    }
}