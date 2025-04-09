using System.Text;

public class Report : FinancialTracker
{
    private string _filePath;

    public Report(string filePath, decimal targetAnnualSavings)
        : base(targetAnnualSavings)
    {
        _filePath = filePath;
    }

    public void CreateFileReport(List<Transaction> transactions)
    {
        if (transactions.Count == 0)
        {
            File.WriteAllText(_filePath, "No transactions to report.");
            return;
        }

        var sb = new StringBuilder();
        sb.AppendLine("Transaction Report");
        sb.AppendLine("=================");
        sb.AppendLine($"Generated on: {DateTime.Now}");
        sb.AppendLine();

        foreach (var transaction in transactions)
        {
            sb.AppendLine(transaction.GetTransactionDetails());
        }

        sb.AppendLine();
        sb.AppendLine("YTD Progress:");
        sb.AppendLine(CheckYTDProgress(transactions));

        File.WriteAllText(_filePath, sb.ToString());
    }

    public void ReadReport()
    {
        if (File.Exists(_filePath))
        {
            string contents = File.ReadAllText(_filePath);
            Console.WriteLine(contents);
        }
        else
        {
            Console.WriteLine("Report file not found.");
        }
    }

    public string CheckYTDProgress(List<Transaction> transactions)
    {
        var currentYear = DateTime.Now.Year;
        var ytdTransactions = transactions
            .Where(t => t.GetDate().Year == currentYear && t is Income);

        decimal totalIncome = ytdTransactions.Sum(t => t.GetAmount());
        decimal progress = (_goal == 0) ? 0 : (totalIncome / _goal) * 100;

        return $"YTD Progress: {progress:F2}% towards goal of {_goal:C}.";
    }

    public override void SetGoal(decimal newGoal)
    {
        _goal = newGoal;
    }
}
