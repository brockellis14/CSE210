public class FinancialTracker
{
    private TransactionBank _bank;
    private decimal _currentBalance;
    protected decimal _goal;

    public FinancialTracker(TransactionBank bank, decimal targetAnnualSavings)
    {
        _bank = bank;
        _goal = targetAnnualSavings;
    }

    public void AddTransaction(Transaction transaction)
    {
        _currentBalance += transaction.Amount;
        _bank.AddTransaction(transaction);
    }

    public decimal GetTotalBalance()
    {
        return _currentBalance;
    }

    public List<Transaction> GetTransactions(DateTime startDate, DateTime endDate)
    {
        return _bank.GetAllTransactions()
                    .Where(t => t.Date >= startDate && t.Date <= endDate)
                    .ToList();
    }
}
