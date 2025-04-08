using System.Text;


public class TransactionBank
{
    private List<Transaction> _transactions = new List<Transaction>();

    public void AddTransaction(Transaction transaction)
    {
        _transactions.Add(transaction);
    }

    public List<Transaction> GetAllTransactions()
    {
        return _transactions;
    }

    public string CreateReport()
    {
        if (_transactions.Count == 0)
            return "No transactions to display.";

        var report = new StringBuilder();
        report.AppendLine("Transaction History:");
        report.AppendLine("--------------------");

        foreach (var transaction in _transactions)
        {
            report.AppendLine(transaction.GetTransactionDetails());
        }

        return report.ToString();
    }

    public string CreateCashFlowReport()
    {
        if (_transactions.Count == 0)
            return "No transactions to report.";

        var transactionsByWeek = _transactions
            .GroupBy(t => FirstDayOfWeek(t.Date))
            .OrderBy(g => g.Key);

        var report = new StringBuilder();
        report.AppendLine("Weekly Cash Flow Report:");
        report.AppendLine("-------------------------");

        foreach (var weekGroup in transactionsByWeek)
        {
            decimal totalIncome = 0;
            decimal totalExpenses = 0;

            foreach (var transaction in weekGroup)
            {
                if (transaction.Amount >= 0)
                    totalIncome += transaction.Amount;
                else
                    totalExpenses += Math.Abs(transaction.Amount);
            }

            decimal savings = totalIncome - totalExpenses;
            report.AppendLine($"Week starting {weekGroup.Key:yyyy-MM-dd}: Saved ${savings:F2}");
        }

        return report.ToString();
    }

    private DateTime FirstDayOfWeek(DateTime date)
    {
        int diff = date.DayOfWeek - DayOfWeek.Sunday;
        if (diff < 0) diff += 7;
        return date.AddDays(-1 * diff).Date;
    }
}
