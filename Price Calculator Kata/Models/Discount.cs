namespace Price_Calculator_Kata.Models
{
    abstract public class Discount
    {
        public double _discount = 0;
        public UPCDiscountCalculator uPCDiscount;
        public UniversalDiscountCalculator universalDiscount;
        public Discount()
        {
            uPCDiscount = ServicesProvider.CreateUPCDiscountCalculator();
            universalDiscount = ServicesProvider.CreateUniversalDiscountCalculator();
        }
        abstract public double CalcPreTaxDiscounts(Product product);
        abstract public double CalcAfterTaxDiscounts(Product product);
    }
}