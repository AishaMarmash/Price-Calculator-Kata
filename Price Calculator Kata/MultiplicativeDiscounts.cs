using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Calculator_Kata
{
    public class MultiplicativeDiscounts : IDiscount
    {
        static double _discount = 0;
        public double CalcPreTaxDiscounts(Product product)
        {
            _discount = 0;
            if (UniversalDiscount.When == DiscountTime.before)
            {
                ApplyUniversalDiscount(product);
            }
            if (UPCDiscount.When ==DiscountTime.before)
            {
                ApplyUpcDiscount(product);
            }
            return Math.Round(_discount, 4);
        }

        public double CalcAfterTaxDiscounts(Product product)
        {
            _discount = 0;
            if (UniversalDiscount.When == DiscountTime.after)
            {
                ApplyUniversalDiscount(product);
            }
            if (UPCDiscount.When == DiscountTime.after)
            {
                ApplyUpcDiscount(product);
            }
            return Math.Round(_discount, 4);
        }

        private static void ApplyUniversalDiscount(Product product)
        {
            double value;
            value = UniversalDiscount.CalculateDiscount(product);
            product.CurrentPrice -= value;
            _discount += value;
        }

        private static void ApplyUpcDiscount(Product product)
        {
            double value = 0;
            value += UPCDiscount.CalculateDiscount(product);
            product.CurrentPrice -= value;
            _discount += value;
        }
    }
}