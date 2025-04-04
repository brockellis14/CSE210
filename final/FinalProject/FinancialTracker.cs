public class FinancialTracker
{
    private List<Transaction> _transactions;
    private float _currentBalance;
    private float _goal;

    public FinancialTracker(float targetAnnualSavings)
    {
        _goal = targetAnnualSavings;
    }

    public void AddTransaction(Transaction transaction)
    {

    }

    public decimal GetTotalBalance()
    {
        return _currentBalance;
    }
    public List<Transaction> GetTransactions(DateTime startDate, DateTime endDate)
    {
        return _transactions;
    }
    public abstract void GenerateReport(string filePath)
    {
        _filePath = filePath;
    }
    public abstract void ReadReport(string filePath)
    {
        _filePath = filePath;
    }

}