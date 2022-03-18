using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Calculator_Kata
{
    internal class Price
    {
        public static double TaxAmount = 0; 
        public static double UniversalDiscountValue = 0;
        public static double UpcDiscountValue = 0;
        public static double TotalDiscount = 0;

        public static double CalculatePrice(Product product)
        {
            CalculatePriceBeforeTax(product);
            CalculatePriceAfterTax(product);
            return Math.Round(product.CurrentPrice, 2);
        }
        private static void CalculatePriceBeforeTax(Product product)
        {
            if (UPCDiscount.when == "before")
            {
                UpcDiscountValue = UPCDiscount.CalculateUpcDiscount(product);
                UpcDiscountValue = Math.Round(UpcDiscountValue, 2);
                product.CurrentPrice -= UpcDiscountValue;
            }
            if (UniversalDiscount.when == "before")
            {
                UniversalDiscountValue = UniversalDiscount.CalculateUniversalDiscount(product);
                UniversalDiscountValue = Math.Round(UniversalDiscountValue, 2);
                product.CurrentPrice -= UniversalDiscountValue;
            }
            TotalDiscount = UniversalDiscountValue + UpcDiscountValue;
        }
        private static void CalculatePriceAfterTax(Product product)
        {
            UpcDiscountValue = 0;
            UniversalDiscountValue = 0;
            if (UPCDiscount.when == "after")
            {
                UpcDiscountValue = UPCDiscount.CalculateUpcDiscount(product);
                UpcDiscountValue = Math.Round(UpcDiscountValue, 2);
                Console.WriteLine("a");
            }
            if (UniversalDiscount.when == "after")
            {
                UniversalDiscountValue = UniversalDiscount.CalculateUniversalDiscount(product);
                UniversalDiscountValue = Math.Round(UniversalDiscountValue, 2);
                Console.WriteLine("b");
            }
            TotalDiscount += UniversalDiscountValue + UpcDiscountValue;
            TaxAmount = Tax.CalculateTax(product);
            double expenses = Expenses.ClaculateExpenses(product);
            product.CurrentPrice = product.CurrentPrice + TaxAmount - UniversalDiscountValue - UpcDiscountValue + expenses;
        }
    }
}