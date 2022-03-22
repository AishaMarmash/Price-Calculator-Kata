using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Calculator_Kata
{
    public class AdditiveDiscounts : IDiscount
    {
        static double _discount = 0;
        public double CalcPreTaxDiscounts(Product product)
        {
            _discount = 0;
            if (UniversalDiscount.When == DiscountTime.before)
            {
                _discount += UniversalDiscount.CalculateDiscount(product);
            }
            if (UPCDiscount.When == DiscountTime.before)
            {
                _discount += UPCDiscount.CalculateDiscount(product);
            }
            product.CurrentPrice -= Math.Round(_discount, 4);
            return Math.Round(_discount, 4);
        }
        public double CalcAfterTaxDiscounts(Product product)
        {
            _discount = 0;
            if (UniversalDiscount.When == DiscountTime.after)
            {
                _discount += UniversalDiscount.CalculateDiscount(product);
            }
            if (UPCDiscount.When == DiscountTime.after)
            {
                _discount += UPCDiscount.CalculateDiscount(product);
            }
            product.CurrentPrice -= Math.Round(_discount, 4);
            return Math.Round(_discount, 4);
        }
    }
}
