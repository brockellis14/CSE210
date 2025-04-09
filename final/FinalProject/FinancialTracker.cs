using System.Text;

public class FinancialTracker
{
    protected List<Transaction> _transactions = new List<Transaction>();
    protected decimal _currentBalance;
    protected decimal _goal;

    public FinancialTracker(decimal targetAnnualSavings)
    {
        _goal = targetAnnualSavings;
    }

    public void AddTransaction(Transaction transaction)
    {
        _transactions.Add(transaction);
        _currentBalance += transaction.GetAmount();
    }

    public decimal GetTotalBalance()
    {
        return _currentBalance;
    }

    public virtual void SetGoal(decimal newGoal)
    {
        _goal = newGoal;
    }

    public decimal GetGoal()
    {
        return _goal;
    }

    public List<Transaction> GetAllTransactions()
    {
        return _transactions;
    }

    public List<Transaction> GetTransactions(DateTime startDate, DateTime endDate)
    {
        return _transactions
            .Where(t => t.GetDate() >= startDate && t.GetDate() <= endDate)
            .ToList();
    }

    public string CreateReport()
    {
        if (_transactions.Count == 0)
            return "No transactions to display.";

        var sb = new StringBuilder();
        sb.AppendLine("Transaction History:");
        sb.AppendLine("--------------------");

        foreach (var transaction in _transactions)
        {
            sb.AppendLine(transaction.GetTransactionDetails());
        }

        return sb.ToString();
    }

    public string CreateCashFlowReport()
    {
        if (_transactions.Count == 0)
            return "No transactions to report.";

        var transactionsByWeek = _transactions
            .GroupBy(t => FirstDayOfWeek(t.GetDate()))
            .OrderBy(g => g.Key);

        var sb = new StringBuilder();
        sb.AppendLine("Weekly Cash Flow Report:");
        sb.AppendLine("-------------------------");

        foreach (var weekGroup in transactionsByWeek)
        {
            decimal totalIncome = 0;
            decimal totalExpenses = 0;

            foreach (var transaction in weekGroup)
            {
                if (transaction.GetAmount() >= 0)
                    totalIncome += transaction.GetAmount();
                else
                    totalExpenses += Math.Abs(transaction.GetAmount());
            }

            decimal savings = totalIncome - totalExpenses;
            sb.AppendLine($"Week starting {weekGroup.Key:yyyy-MM-dd}: Saved ${savings:F2}");
        }

        return sb.ToString();
    }

    private DateTime FirstDayOfWeek(DateTime date)
    {
        int diff = date.DayOfWeek - DayOfWeek.Sunday;
        if (diff < 0) diff += 7;
        return date.AddDays(-1 * diff).Date;
    }
}