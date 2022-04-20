using Price_Calculator_Kata.Services;
using Price_Calculator_Kata.Models;

namespace Price_Calculator_Kata
{
    public class ServicesProvider
    {
        public static UPCDiscountRegistration CreateUPCDiscountRegistration()
        {
            return new UPCDiscountRegistration();
        }
        public static ExpensesRegister CreateExpensesRegister(ref Product product)
        {
            return new ExpensesRegister(ref product);
        }
        public static ExpensesCalculator CreateExpensesCalculator()
        {
            return new ExpensesCalculator();
        }
        public static PriceCalculator CreatePriceCalculator()
        {
            return new PriceCalculator();
        }
        public static ReportsManager CreateReportsManager()
        {
            return new ReportsManager();
        }
        public static TaxCalculator CreateTaxCalculator()
        {
            return new TaxCalculator();
        }
        public static AdditiveDiscounts CreateAdditiveDiscounts()
        {
            return new AdditiveDiscounts();
        }
        public static MultiplicativeDiscounts CreateMultiplicativeDiscounts()
        {
            return new MultiplicativeDiscounts();
        }
        public static UPCDiscountCalculator CreateUPCDiscountCalculator()
        {
            return new UPCDiscountCalculator();
        }
        public static UniversalDiscountCalculator CreateUniversalDiscountCalculator()
        {
            return new UniversalDiscountCalculator();
        }
    }
}