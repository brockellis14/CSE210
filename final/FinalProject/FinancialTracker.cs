public class FinancialTracker
{
    private List<Transaction> _transactions = new List<Transaction>();
    private float _currentBalance;
    private float _goal;

    public FinancialTracker(float targetAnnualSavings)
    {
        _goal = targetAnnualSavings;
    }

    public void AddTransaction(Transaction transaction)
    {
        _transactions.Add(transaction);
        _currentBalance += transaction.GetAmount(); 
    }

    public float GetTotalBalance()
    {
        return _currentBalance;
    }

    public List<Transaction> GetTransactions(DateTime startDate, DateTime endDate)
    {
        return _transactions.Where(t => t.GetDateTime() >= startDate && t.GetDateTime() <= endDate).ToList();
    }


    //public void GenerateReport(string filePath)

    //public void ReadReport(string filePath)
}