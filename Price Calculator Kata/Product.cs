namespace Price_Calculator_Kata
{
    internal class Product
    {
        public string Name { get; set; }
        public int UPC { get; set; }
        public double BasePrice { get; set; }
        public double Price { get; set; }

        public Product(string name, int upc, double price )
        {
            Name = name;
            UPC = upc;
            Price = price;
            BasePrice = price;
        }
        public string ProductPriceInfo()
        {
            return $"Product price reported as ${BasePrice:0.00} before tax and ${Price:0.00} after {Tax._taxValue}% tax.";
        }
    }
}