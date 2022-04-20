using Price_Calculator_Kata.Services;

namespace Price_Calculator_Kata
{
    public class PriceCalculator
    {
        public double TaxAmount = 0;
        public double TotalDiscount = 0;
        public double PreTaxDiscount = 0;
        public double AfterTaxDiscount = 0;
        public double ExpensesAmount = 0;
        public DiscountTypes DiscountType = DiscountTypes.additave;
        public double CalculatePrice(Product product)
        {
            IDiscountTime discount = ServicesProvider.CreateAdditiveDiscounts();
            if (DiscountType == DiscountTypes.additave)
            {
                discount = ServicesProvider.CreateAdditiveDiscounts();
            }
            else if(DiscountType == DiscountTypes.multiplicative)
            {
                discount = ServicesProvider.CreateMultiplicativeDiscounts();
            }
            PreTaxDiscount = discount.CalcPreTaxDiscounts(product);

            TaxCalculator taxCalculator = ServicesProvider.CreateTaxCalculator();
            TaxAmount = taxCalculator.Calculate(product);

            AfterTaxDiscount = discount.CalcAfterTaxDiscounts(product);

            ExpensesCalculator expenses = ServicesProvider.CreateExpensesCalculator();
            ExpensesAmount = expenses.Claculate(product);
            TotalDiscount = PreTaxDiscount + AfterTaxDiscount;

            TotalDiscount = CapManager.ApplyCap(product ,TotalDiscount);

            product.CurrentPrice = product.CurrentPrice + TaxAmount + ExpensesAmount;
            return Math.Round(product.CurrentPrice, 2);
        }
    }
}