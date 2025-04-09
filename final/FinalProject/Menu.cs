using System;

public class Menu
{
    private FinancialTracker tracker;
    private Report report;
    private string reportFileName;

    public Menu(FinancialTracker tracker, Report report, string reportFileName)
    {
        this.tracker = tracker;
        this.report = report;
        this.reportFileName = reportFileName;
    }

    public void DisplayMenu()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n--- Financial Tracker Menu ---");
            Console.WriteLine("1. Set/Change Annual Savings Goal");
            Console.WriteLine("2. Create Transaction");
            Console.WriteLine("3. View All Transactions");
            Console.WriteLine("4. View Cash Flow Report");
            Console.WriteLine("5. Check YTD Progress");
            Console.WriteLine("6. Write Report to File");
            Console.WriteLine("7. Read Report from File");
            Console.WriteLine("8. Quit");
            Console.Write("Enter your choice (1-8): ");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    decimal newGoal = PromptHelper.PromptDecimal("Enter new annual savings goal");
                    tracker.SetGoal(newGoal);
                    report.SetGoal(newGoal);
                    Console.WriteLine($"Goal set to ${newGoal}.");
                    break;

                case "2":
                    Transaction transaction = TransactionFactory.CreateTransaction();
                    tracker.AddTransaction(transaction);
                    Console.WriteLine("Transaction added.");
                    break;

                case "3":
                    Console.WriteLine(tracker.CreateReport());
                    break;

                case "4":
                    Console.WriteLine(tracker.CreateCashFlowReport());
                    break;

                case "5":
                    Console.WriteLine(report.CheckYTDProgress(tracker.GetAllTransactions()));
                    break;

                case "6":
                    reportFileName = PromptHelper.PromptString("Enter file name to save report (e.g., myReport.txt)");
                    report = new Report(reportFileName, tracker.GetGoal());
                    report.CreateFileReport(tracker.GetAllTransactions());
                    Console.WriteLine($"Report written to file: {reportFileName}");
                    break;

                case "7":
                    string readFileName = PromptHelper.PromptString("Enter file name to read (e.g., myReport.txt)");
                    var readReport = new Report(readFileName, tracker.GetGoal());
                    Console.WriteLine($"\n-- Reading from {readFileName} --");
                    readReport.ReadReport();
                    break;

                case "8":
                    running = false;
                    Console.WriteLine("Exiting program. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 8.");
                    break;
            }
        }
    }
}
