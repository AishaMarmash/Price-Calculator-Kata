namespace Price_Calculator_Kata
{
    public class Product
    {
        public string Name { get; set; }
        public int? UPC { get; set; }
        public double BasePrice { get; set; }
        public double CurrentPrice { get; set; }
        public int UPCDiscount { get; set; }
        public DiscountTime? UPCDiscountTime { get; set; }
        public Dictionary<string, double> ExpensesList { get; set; }
        public Product()
        {
            Name = "unnamed";
            UPC = null;
            UPCDiscount = 0;
            UPCDiscountTime = null;
            ExpensesList = new Dictionary<string, double>();
        }
        public Product(string name, int upc, double price )
        {
            Name = name;
            UPC = upc;
            CurrentPrice = BasePrice = price;
            UPCDiscountTime = DiscountTime.after;
            ExpensesList = new Dictionary<string, double>();
        }
    }
}