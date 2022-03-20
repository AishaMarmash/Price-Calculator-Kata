using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Calculator_Kata
{
    internal class Report
    {
        static string? _report;
        public static string? PrintReport(List<Product> products)
        {
            foreach (var product in products)
            {
                _report += $"Cost =  {Math.Round(product.BasePrice,2)} {Currancy.Type}{Environment.NewLine}";
                if(Price.TaxAmount != 0)
                { _report += $"Tax = {Math.Round(Price.TaxAmount,2)} {Currancy.Type}{ Environment.NewLine}";}             
                if (Price.TotalDiscount != 0)
                { _report += $"Discount = {Math.Round(Price.TotalDiscount,2)} {Currancy.Type}{ Environment.NewLine}";}
                foreach(KeyValuePair<string, double> kvp in Expenses.ExpensesList)
                {
                    _report += $"{kvp.Key} = {Math.Round(kvp.Value,2)} {Currancy.Type}{Environment.NewLine}";
                }
                _report += $"Total = {Math.Round(product.CurrentPrice,2)} {Currancy.Type}{Environment.NewLine}";

                if (Price.TotalDiscount != 0)
                { _report += $"Total Discount = {Math.Round(Price.TotalDiscount,2)} {Currancy.Type}{Environment.NewLine}";}
                else
                { _report += "no discounts";}
            }
            return _report;
        }
    }
}
