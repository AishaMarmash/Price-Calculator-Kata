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
        public static void PrintReport(List<Product> products)
        {
            foreach (var product in products)
            {
                if (product == null) return;
                _report += GetCost(product);
                _report += GetTax();
                _report += GetDiscounts();
                _report += GetExpenses();
                _report += GetTotalPrice(product);
                _report += ReportTotalDiscount();
            }
            Console.Write(_report);
        }

        private static string? GetCost(Product product)
        {
            return $"Cost =  {Math.Round(product.BasePrice, 2):0.00} {Currency.Type}{Environment.NewLine}";
        }

        private static string? GetTax()
        {
            if (Price.TaxAmount != 0)
                return $"Tax = {Math.Round(Price.TaxAmount, 2):0.00} {Currency.Type}{ Environment.NewLine}"; 
            else
                return null;
        }
        private static string? GetDiscounts()
        {
            if (Price.TotalDiscount != 0)
                return $"Discount = {Math.Round(Price.TotalDiscount, 2):0.00} {Currency.Type}{ Environment.NewLine}";
            else
                return null;
        }

        private static string? GetExpenses()
        {
            string? expenses = null;
            foreach (KeyValuePair<string, double> kvp in Expenses.ExpensesList)
            {
                expenses += $"{kvp.Key} = {Math.Round(kvp.Value, 2):0.00} {Currency.Type}{Environment.NewLine}";
            }
            return expenses;
        }

        private static string? GetTotalPrice(Product product)
        {
            return $"Total = {Math.Round(product.CurrentPrice,2):0.00} {Currency.Type}{Environment.NewLine}";
        }

        private static string? ReportTotalDiscount()
        {
            if (Price.TotalDiscount != 0)
            { 
                return $"Total Discount = {Math.Round(Price.TotalDiscount, 2):0.00} {Currency.Type}{Environment.NewLine}"; 
            }
            else
            { 
                return "no discounts"; 
            }
        }
    }
}
