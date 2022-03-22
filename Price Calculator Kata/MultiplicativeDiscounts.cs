﻿using System;
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
                ApplyUniversalDiscount(ref product);
            }
            if (UPCDiscount.When ==DiscountTime.before)
            {
                ApplUpcDiscount(ref product);
            }
            return Math.Round(_discount, 4);
        }

        public double CalcAfterTaxDiscounts(Product product)
        {
            _discount = 0;
            if (UniversalDiscount.When == DiscountTime.after)
            {
                ApplyUniversalDiscount(ref product);
            }
            if (UPCDiscount.When == DiscountTime.after)
            {
                ApplUpcDiscount(ref product);
            }
            return Math.Round(_discount, 4);
        }
        private void ApplyUniversalDiscount(ref Product product)
        {
            double value = 0;
            value = UniversalDiscount.CalculateDiscount(product);
            product.CurrentPrice -= value;
            _discount += value;
        }
        private void ApplUpcDiscount(ref Product product)
        {
            double value = 0;
            value += UPCDiscount.CalculateDiscount(product);
            product.CurrentPrice -= value;
            _discount += value;
        }
    }
}