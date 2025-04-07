public class Report : FinancialTracker
{
    private string _filePath;

    public Report(string filePath, decimal targetAnnualSavings) : base(targetAnnualSavings)
    {
        _filePath = filePath;
    }

    // Method to create the report into file
    public void CreateReport(List<Transaction> transactions)
    {
        // Implementation of report generation
    }

    // Method to read the report
    public void ReadReport()
    {
        // Implementation of reading the report
    }

    // Method to check YTD progress
    public string CheckYTDProgress(List<Transaction> transactions)
    {
        decimal totalIncome = transactions.Where(t => t is Income).Sum(t => t.Amount);
        decimal progress = (totalIncome / _goal) * 100;

        return $"YTD Progress: {progress}% towards goal of {_goal}.";
    }
}