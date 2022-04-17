﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Calculator_Kata
{
    public class Expenses
    {
        public static Product ProductRef = new();
        public static Dictionary<string, double> ExpensesList = new();
        public Expenses(Product product)
        {
            ProductRef.Name = product.Name;
            ProductRef.BasePrice = product.BasePrice;
            ProductRef.CurrentPrice = product.CurrentPrice;
            ProductRef.UPC = product.UPC;
        }
        public static void Add(string description, string amount)
        {
            ExpensesList.Add(description, ParseAmount(amount));
        }

        private static double ParseAmount(string amount)
        {
            double Amount;
            if (amount.Contains('%'))
            {
                int indexOfPercent = amount.IndexOf('%');
                amount = amount.Remove(indexOfPercent);
                Amount = (double.Parse(amount) / 100) * ProductRef.BasePrice;
            }
            else
            {
                Amount = double.Parse(amount);
            }
            return Math.Round(Amount,4);
        }
        public static double ClaculateExpenses()
        {
            double totalExpenses = 0;
            foreach(KeyValuePair<string, double> kvp in ExpensesList)
            {
                totalExpenses += kvp.Value;
            }
            return totalExpenses;
        }
    }
}