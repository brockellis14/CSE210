using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

public class Report : FinancialTracker
{
    private string _filePath;
    private TransactionBank _bank;

    public Report(TransactionBank bank, string filePath, decimal targetAnnualSavings)
        : base(bank, targetAnnualSavings)
    {
        _bank = bank;
        _filePath = filePath;
    }

    public void CreateReport()
    {
        var allTransactions = _bank.GetAllTransactions();

        if (allTransactions.Count == 0)
        {
            File.WriteAllText(_filePath, "No transactions to report.");
            return;
        }

        var sb = new StringBuilder();
        sb.AppendLine("Transaction Report");
        sb.AppendLine("=================");
        sb.AppendLine($"Generated on: {DateTime.Now}");
        sb.AppendLine();

        foreach (var transaction in allTransactions)
        {
            sb.AppendLine(transaction.GetTransactionDetails());
        }

        sb.AppendLine();
        sb.AppendLine("YTD Progress:");
        sb.AppendLine(CheckYTDProgress());

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

    public string CheckYTDProgress()
    {
        var currentYear = DateTime.Now.Year;
        var ytdTransactions = _bank.GetAllTransactions()
            .Where(t => t.Date.Year == currentYear && t is Income);

        decimal totalIncome = ytdTransactions.Sum(t => t.Amount);
        decimal progress = (_goal == 0) ? 0 : (totalIncome / _goal) * 100;

        return $"YTD Progress: {progress:F2}% towards goal of {_goal}.";
    }
}
