public class FinancialTracker
{
    private List<Transaction> _transactions = new List<Transaction>();
    private decimal _currentBalance; // Changed to decimal
    protected decimal _goal;

    public FinancialTracker(decimal targetAnnualSavings)
    {
        _goal = targetAnnualSavings;
    }

    public void AddTransaction(Transaction transaction)
    {
        _transactions.Add(transaction);
        _currentBalance += transaction.Amount; // Now both are decimal
    }

    public decimal GetTotalBalance()
    {
        return _currentBalance;
    }

    public List<Transaction> GetTransactions(DateTime startDate, DateTime endDate)
    {
        return _transactions.Where(t => t.Date >= startDate && t.Date <= endDate).ToList();
    }
}