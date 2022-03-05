using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Calculator_Kata
{
    internal class Product
    {
        private double _priceBeforeTax;
        private static int _tax = 20;
        public string Name { get; set; }
        public int UPC { get; set; }
        public double PriceAfterTax
        { get; set; }
        public double PriceBeforeTax 
        {
            get 
            {
                return _priceBeforeTax;
            }
            set
            {
                PriceAfterTax = value + (value * (Tax / 100.0));
                PriceAfterTax = Math.Round(PriceAfterTax, 2);
                _priceBeforeTax = value;
            }
        }

        public static int Tax 
        { 
            get
            {
                return _tax;
            }
            set
            {
                _tax = value;
            } 
        }

        public Product(string name, int upc, double price )
        {
            Name = name;
            UPC = upc;
            PriceBeforeTax = price;
        }
        public string ProductPriceInformation ()
        {
            return $"Product price reported as ${PriceBeforeTax:0.00} before tax and ${PriceAfterTax:0.00} after {Tax}% tax.";
        }
    }
}
