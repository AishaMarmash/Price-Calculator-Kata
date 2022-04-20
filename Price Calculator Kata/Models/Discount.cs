using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Calculator_Kata.Models
{
    abstract public class Discount
    {
        public double _discount = 0;
        public UPCDiscountCalculator uPCDiscount;
        public UniversalDiscountCalculator universalDiscount;
        public Discount()
        {
            uPCDiscount = new UPCDiscountCalculator();
            universalDiscount = new UniversalDiscountCalculator();
        }
        abstract public double CalcPreTaxDiscounts(Product product);
        abstract public double CalcAfterTaxDiscounts(Product product);
    }
}