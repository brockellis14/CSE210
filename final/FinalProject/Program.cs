using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Initialize transactions and financial tracker
        var financialTracker = new FinancialTracker(10000);


        // Create various transactions
        var income1 = new Income(500, "Salary", "March Salary", "Company A", false);
        var income2 = new ReoccurringIncome("Bonus", 2000, "Yearly Bonus", "Company A", "Company B", TimeSpan.FromDays(365));
        var expense1 = new Expense("Utilities", 150, "Electric Bill", "Monthly bill for electricity");
        var expense2 = new ReoccurringExpense("Rent", 1200, "Monthly Rent", "Apartment rent", "Necessity", TimeSpan.FromDays(30));
        var lumpSumIncome = new LumpSum("Project Income", 5000, "Freelance", "Freelance work", true, "Company C");
        var intervalExpense = new IntervalExpense("Food", -300, "Grocery Shopping", "Weekly grocery shopping");


        // Add transactions to financial tracker, NEED TO MAKE THIS AUTOMATIC FOR EASE OF USE
        financialTracker.AddTransaction(income1);
        financialTracker.AddTransaction(income2);
        financialTracker.AddTransaction(expense1);
        financialTracker.AddTransaction(expense2);
        financialTracker.AddTransaction(lumpSumIncome);
        financialTracker.AddTransaction(intervalExpense);


        // Display transactions
        Console.WriteLine("\n-- All Transactions --");
        var transactionBank = new TransactionBank();
        transactionBank.AddTransaction(income1);
        transactionBank.AddTransaction(income2);
        transactionBank.AddTransaction(expense1);
        transactionBank.AddTransaction(expense2);
        transactionBank.AddTransaction(lumpSumIncome);
        transactionBank.AddTransaction(intervalExpense);

        // Print reports
        Console.WriteLine("\n-- Transaction Report --");
        Console.WriteLine(transactionBank.CreateReport());

        Console.WriteLine("\n-- Cash Flow Report --");
        Console.WriteLine(transactionBank.CreateCashFlowReport());

        // Check YTD progress
        var report = new Report("report.txt", 10000);
        Console.WriteLine("\n-- YTD Progress Report --");
        Console.WriteLine(report.CheckYTDProgress(new List<Transaction> { income1, income2, lumpSumIncome }));

        // Test displaying individual transactions
        Console.WriteLine("\n-- Displaying Individual Transactions --");
        Console.WriteLine(income1.DisplayTransaction());
        Console.WriteLine(income2.DisplayTransaction());
        Console.WriteLine(expense1.DisplayTransaction());
        Console.WriteLine(expense2.DisplayTransaction());
        Console.WriteLine(lumpSumIncome.DisplayTransaction());
        Console.WriteLine(intervalExpense.DisplayTransaction());

        // Create and display detailed transaction for an Expense
        Console.WriteLine("\n-- Detailed Transaction --");
        Console.WriteLine(expense1.GetTransactionDetails());
    }
}
