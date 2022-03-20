using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Calculator_Kata
{
    interface IDiscount
    {
        public double CalcPreTaxDiscounts(Product product);
        public double CalcAfterTaxDiscounts(Product product);
    }
}
