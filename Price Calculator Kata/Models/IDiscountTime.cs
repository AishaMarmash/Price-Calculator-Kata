namespace Price_Calculator_Kata
{
    interface IDiscountTime
    {
        public double CalcPreTaxDiscounts(Product product);
        public double CalcAfterTaxDiscounts(Product product);
    }
}
