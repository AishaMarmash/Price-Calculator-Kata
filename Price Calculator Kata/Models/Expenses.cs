namespace Price_Calculator_Kata.Models
{
    public class Expenses
    {
        public Product Product = new();
        public Expenses(Product product)
        {
            Product.Name = product.Name;
            Product.BasePrice = product.BasePrice;
            Product.CurrentPrice = product.CurrentPrice;
            Product.UPC = product.UPC;
        }

    }
}
