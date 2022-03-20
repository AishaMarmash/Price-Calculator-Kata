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
            double value = 0;
            _discount = 0;
            if (UniversalDiscount.When == "before")
            {
                value = UniversalDiscount.CalculateDiscount(product);
                product.CurrentPrice -= value;
                _discount += value;
            }
            if (UPCDiscount.When == "before")
            {
                value += UPCDiscount.CalculateDiscount(product);
                product.CurrentPrice -= value;
                _discount += value;
            }
            return Math.Round(_discount, 4);
        }

        public double CalcAfterTaxDiscounts(Product product)
        {
            double value = 0;
            _discount = 0;
            if (UniversalDiscount.When == "after")
            {
                value = UniversalDiscount.CalculateDiscount(product);
                product.CurrentPrice -= value;
                _discount += value;
            }
            if (UPCDiscount.When == "after")
            {
                value = UPCDiscount.CalculateDiscount(product);
                product.CurrentPrice -= value;
                _discount += value;
            }
            return Math.Round(_discount, 4);
        }
    }
}