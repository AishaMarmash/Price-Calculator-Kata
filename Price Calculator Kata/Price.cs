using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Calculator_Kata
{
    internal class Price
    {
        public static double TaxAmount = 0;
        public static double TotalDiscount = 0;
        public static double PreTaxDiscount = 0;
        public static double AfterTaxDiscount = 0;
        public static double ExpensesAmount = 0;
        public static DiscountTypes DiscountType = DiscountTypes.additave;
        public static double CalculatePrice(Product product)
        {
            IDiscount discount = new AdditiveDiscounts();
            if (DiscountType == DiscountTypes.additave)
            {
                discount = new AdditiveDiscounts();
            }
            else if(DiscountType == DiscountTypes.multiplicative)
            {
                discount = new MultiplicativeDiscounts();
            }
            PreTaxDiscount = discount.CalcPreTaxDiscounts(product);
            TaxAmount = Tax.CalculateTax(product);
            AfterTaxDiscount = discount.CalcAfterTaxDiscounts(product);
            ExpensesAmount = Expenses.ClaculateExpenses();
            TotalDiscount = PreTaxDiscount + AfterTaxDiscount;
            Cap.ApplyCap(product);
            product.CurrentPrice = product.CurrentPrice + TaxAmount + ExpensesAmount;
            return Math.Round(product.CurrentPrice, 2);
        }
    }
}