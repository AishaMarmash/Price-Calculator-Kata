namespace Price_Calculator_Kata
{
    public class Product
    {
        public string? Name { get; set; }
        public int? UPC { get; set; }
        public double BasePrice { get; set; }
        public double CurrentPrice { get; set; }
        public int UPCDiscount { get; set; }
        public Product()
        { }
        public Product(string name, int upc, double price )
        {
            Name = name;
            UPC = upc;
            CurrentPrice = BasePrice = price;
        }
    }
}