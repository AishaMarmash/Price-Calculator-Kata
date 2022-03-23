﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Calculator_Kata
{
    internal class UPCDiscount
    {
        public static double DiscountAmount;
        public static DiscountTime When = DiscountTime.after;

        public static void SetDiscountPercentage(List<Product> products, int upcValue, int discountPercentage)
        {
            var query = products.Where(n => n.UPC == upcValue).Select(n => n).ToList();
            foreach (var product in query)
            {
                product.UPCDiscount = discountPercentage;
            }
        }
        public static double CalculateDiscount(Product product)
        {
            DiscountAmount = product.CurrentPrice * (product.UPCDiscount / 100.0);
            return Math.Round(DiscountAmount, 4);
        }
    }
}