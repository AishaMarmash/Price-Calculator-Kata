namespace Price_Calculator_Kata.Services
{
    public class UPCDiscountRegistration
    {
        public void SetDiscountPercentage(List<Product> products, int upcValue, int discountPercentage, DiscountTime when)
        {
            var query = products.Where(n => n.UPC == upcValue).Select(n => n).ToList();
            foreach (var product in query)
            {
                product.UPCDiscount = discountPercentage;
                product.UPCDiscountTime = when;
            }
        }
    }
}
