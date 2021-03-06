namespace Price_Calculator_Kata
{
    public class ExpensesRegister
    {
        readonly Product _product;
        public ExpensesRegister(ref Product product)
        {
            _product = product;
        }
        public void Add(string description, string amount)
        {
            _product.ExpensesList.Add(description, ParseAmount(amount));
        }
        private double ParseAmount(string amount)
        {
            double Amount;
            if (amount.Contains('%'))
            {
                int indexOfPercent = amount.IndexOf('%');
                amount = amount.Remove(indexOfPercent);
                Amount = (double.Parse(amount) / 100) * _product.BasePrice;
            }
            else
            {
                Amount = double.Parse(amount);
            }
            return Math.Round(Amount,4);
        }
    }
}