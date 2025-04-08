using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        var bank = new TransactionBank();
        var financialTracker = new FinancialTracker(bank, 10000);

        // Create transactions (Income + Expense types)
        var income1 = new Income(500, "Salary", "March Salary", "Company A", false);
        var income2 = new ReoccurringIncome("Bonus", 2000, "Yearly Bonus", "Company A", "Company B", TimeSpan.FromDays(365));
        var lumpSumIncome = new LumpSum("Project Income", 5000, "Freelance", "Freelance work", true, "Company C");

        var expense1 = new Expense("Utilities", -150, "Electric Bill", "Monthly bill for electricity");
        var expense2 = new ReoccurringExpense("Rent", -1200, "Monthly Rent", "Apartment rent", "Necessity", TimeSpan.FromDays(30));
        var intervalExpense = new IntervalExpense("Food", -300, "Grocery Shopping", "Weekly grocery shopping");
        var oneTimeExpense = new OneTimeExpense("Health", -400, "Doctor Visit", "Specialist consultation");

        // Add to FinancialTracker (auto-synced with TransactionBank)
        financialTracker.AddTransaction(income1);
        financialTracker.AddTransaction(income2);
        financialTracker.AddTransaction(lumpSumIncome);
        financialTracker.AddTransaction(expense1);
        financialTracker.AddTransaction(expense2);
        financialTracker.AddTransaction(intervalExpense);
        financialTracker.AddTransaction(oneTimeExpense);

        // Print all transaction details
        Console.WriteLine("\n-- Displaying Individual Transactions --");
        Console.WriteLine(income1.DisplayTransaction());
        Console.WriteLine(income2.DisplayTransaction());
        Console.WriteLine(lumpSumIncome.DisplayTransaction());
        Console.WriteLine(expense1.DisplayTransaction());
        Console.WriteLine(expense2.DisplayTransaction());
        Console.WriteLine(intervalExpense.DisplayTransaction());
        Console.WriteLine(oneTimeExpense.DisplayTransaction());

        // Print transaction details in compact report format
        Console.WriteLine("\n-- GetTransactionDetails() --");
        Console.WriteLine(income1.GetTransactionDetails());
        Console.WriteLine(expense1.GetTransactionDetails());

        // Generate and display a full report from TransactionBank
        Console.WriteLine("\n-- Transaction Report --");
        Console.WriteLine(bank.CreateReport());

        // Weekly grouped income/expense savings
        Console.WriteLine("\n-- Cash Flow Report --");
        Console.WriteLine(bank.CreateCashFlowReport());

        // Create report object
        var report = new Report(bank, "report.txt", 10000);

        // Display YTD progress from Report class
        Console.WriteLine("\n-- YTD Progress Report --");
        Console.WriteLine(report.CheckYTDProgress());

        // Write the full report to file
        report.CreateReport();

        // Read and display contents of the report file
        Console.WriteLine("\n-- Reading Report File --");
        report.ReadReport();

        // Display total balance from FinancialTracker
        Console.WriteLine("\n-- Current Balance --");
        Console.WriteLine($"Total Balance: ${financialTracker.GetTotalBalance():F2}");

        // Display filtered transaction range example (e.g. from 1st of current month to now)
        var startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        var endDate = DateTime.Now;
        var filtered = financialTracker.GetTransactions(startDate, endDate);

        Console.WriteLine($"\n-- Transactions from {startDate.ToShortDateString()} to {endDate.ToShortDateString()} --");
        foreach (var t in filtered)
        {
            Console.WriteLine(t.DisplayTransaction());
        }
    }
}
