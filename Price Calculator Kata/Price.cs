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
        public static string DiscountWay = "additive";
        public static double CalculatePrice(Product product)
        {
            IDiscount discount = new AdditiveDiscounts();
            if (DiscountWay.Equals("additive"))
            {
                discount = new AdditiveDiscounts();
            }
            else if(DiscountWay.Equals("multiplicative"))
            {
                discount = new MultiplicativeDiscounts();
            }
            PreTaxDiscount = discount.CalcPreTaxDiscounts(product);
            TaxAmount = Tax.CalculateTax(product);
            AfterTaxDiscount = discount.CalcAfterTaxDiscounts(product);
            ExpensesAmount = Expenses.ClaculateExpenses(product);
            TotalDiscount = PreTaxDiscount + AfterTaxDiscount;
            Cap.ApplyCap(product);
            product.CurrentPrice = product.CurrentPrice + TaxAmount + ExpensesAmount;
            return Math.Round(product.CurrentPrice, 2);
        }
    }
}