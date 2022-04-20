namespace Price_Calculator_Kata.Services
{
    public class ExpensesCalculator
    {
        double _totalExpenses;
        public double Claculate(Product product)
        {
            _totalExpenses = 0;
            foreach (KeyValuePair<string, double> kvp in product.ExpensesList)
            {
                _totalExpenses += kvp.Value;
            }
            return _totalExpenses;
        }
    }
}