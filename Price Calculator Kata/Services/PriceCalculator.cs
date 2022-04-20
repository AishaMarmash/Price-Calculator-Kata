using Price_Calculator_Kata.Models;
using Price_Calculator_Kata.Services;

namespace Price_Calculator_Kata
{
    internal class PriceCalculator
    {
        public double TaxAmount = 0;
        public double TotalDiscount = 0;
        public double PreTaxDiscount = 0;
        public double AfterTaxDiscount = 0;
        public double ExpensesAmount = 0;
        public DiscountTypes DiscountType = DiscountTypes.additave;
        public double CalculatePrice(Product product)
        {
            IDiscountTime discount = new AdditiveDiscounts();
            if (DiscountType == DiscountTypes.additave)
            {
                discount = new AdditiveDiscounts();
            }
            else if(DiscountType == DiscountTypes.multiplicative)
            {
                discount = new MultiplicativeDiscounts();
            }
            PreTaxDiscount = discount.CalcPreTaxDiscounts(product);

            TaxCalculator taxCalculator = new TaxCalculator();
            TaxAmount = taxCalculator.Calculate(product);

            AfterTaxDiscount = discount.CalcAfterTaxDiscounts(product);

            ExpensesCalculator expenses = new();
            ExpensesAmount = expenses.Claculate(product);
            TotalDiscount = PreTaxDiscount + AfterTaxDiscount;


            TotalDiscount = CapManager.ApplyCap(product ,TotalDiscount);

            product.CurrentPrice = product.CurrentPrice + TaxAmount + ExpensesAmount;
            return Math.Round(product.CurrentPrice, 2);
        }
    }
}