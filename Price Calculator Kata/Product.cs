namespace Price_Calculator_Kata
{
    internal class Product
    {
        public string Name { get; set; }
        public int UPC { get; set; }
        public double BasePrice { get; set; }
        public double CurrentPrice { get; set; }

        public Product(string name, int upc, double price )
        {
            Name = name;
            UPC = upc;
            CurrentPrice = BasePrice = price;
        }
        public string ProductPriceInfo()
        {
            return $"Product price reported as ${BasePrice:0.00} before tax and ${CurrentPrice:0.00} after {Tax._taxPercentage}% tax.";
        }
    }
}