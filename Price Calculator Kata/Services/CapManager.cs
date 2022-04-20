namespace Price_Calculator_Kata
{
    public class CapManager
    {
        public static double ApplyCap(Product product, double TotalDiscount)
        {
            if (Configurations.CapValue == null) { return 0; }
            double capValue = ParseCap(Configurations.CapValue, product);
            if((TotalDiscount > capValue))
            {
                TotalDiscount = capValue;
                product.CurrentPrice = product.BasePrice - capValue;
            }
            return TotalDiscount;
        }
        private static double ParseCap(string value, Product product)
        {
            double capValue;
            double capPercentage;
            if (value.Contains('%'))
            {
                int indexOfPercent = value.IndexOf('%');
                value = value.Remove(indexOfPercent);
                capPercentage = (double.Parse(value) / 100);
                capValue = CalculateCap(capPercentage, product);
            }
            else
            {
                capValue = double.Parse(value);
            }
            return Math.Round(capValue, 2);
        }
        public static double CalculateCap(double Amount,Product product)
        {
            return Math.Round(Amount * product.BasePrice, 4);
        }
    }
}