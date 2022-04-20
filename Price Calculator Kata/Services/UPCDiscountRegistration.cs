namespace Price_Calculator_Kata.Services
{
    public class UPCDiscountRegistration
    {
        public void SetDiscountPercentage(List<Product> products, int upcValue, int discountPercentage, DiscountTime when)
        {
            Product? product = products.Where(pro => pro.UPC == upcValue).Select(pro => pro).SingleOrDefault();
            if (product != null)
            {
                product.UPCDiscount = discountPercentage;
                product.UPCDiscountTime = when;
            }
            else 
            {
                throw new Exception($"not found element with this UPC : {upcValue}");
            }
        }
    }
}