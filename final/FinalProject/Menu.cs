using System;
using System.Collections.Generic;

public class Menu
{
    private FinancialTracker tracker;
    private TransactionBank bank;
    private Report report;
    private string reportFileName = "report.txt";

    public Menu(FinancialTracker tracker, TransactionBank bank, Report report, string reportFileName)
    {
        this.tracker = tracker;
        this.bank = bank;
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
                    decimal newGoal;
                    while (true)
                    {
                        Console.Write("Enter new annual savings goal: ");
                        if (decimal.TryParse(Console.ReadLine(), out newGoal) && newGoal >= 0)
                        {
                            tracker.SetGoal(newGoal);
                            report.SetGoal(newGoal);
                            Console.WriteLine($"Goal set to ${newGoal}.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid number. Please enter a positive decimal.");
                        }
                    }
                    break;

                case "2":
                    CreateTransaction();
                    break;

                case "3":
                    Console.WriteLine("\n-- Transaction Report --");
                    Console.WriteLine(bank.CreateReport());
                    break;

                case "4":
                    Console.WriteLine("\n-- Cash Flow Report --");
                    Console.WriteLine(bank.CreateCashFlowReport());
                    break;

                case "5":
                    Console.WriteLine("\n-- YTD Progress Report --");
                    Console.WriteLine(report.CheckYTDProgress());
                    break;

                case "6":
                    reportFileName = PromptString("Enter file name to save report (e.g., myReport.txt)");
                    report = new Report(bank, reportFileName, tracker.GetGoal());
                    report.CreateReport();
                    Console.WriteLine($"Report written to file: {reportFileName}");
                    break;

                case "7":
                    string readFileName = PromptString("Enter file name to read (e.g., myReport.txt)");
                    var readReport = new Report(bank, readFileName, tracker.GetGoal());
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

    private void CreateTransaction()
    {
        while (true)
        {
            Console.Write("Enter transaction type (income/expense): ");
            string type = Console.ReadLine().ToLower();

            if (type == "income")
            {
                CreateIncomeTransaction();
                break;
            }
            else if (type == "expense")
            {
                CreateExpenseTransaction();
                break;
            }
            else
            {
                Console.WriteLine("Invalid transaction type. Please enter 'income' or 'expense'.");
            }
        }
    }

    private void CreateIncomeTransaction()
    {
        while (true)
        {
            Console.WriteLine("Choose income type:");
            Console.WriteLine("1. LumpSum");
            Console.WriteLine("2. Recurring");
            Console.WriteLine("3. Interval");
            Console.Write("Select (1-3): ");
            string choice = Console.ReadLine();

            if (!new[] { "1", "2", "3" }.Contains(choice))
            {
                Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                continue;
            }

            string name = PromptString("Name");
            decimal amount = PromptDecimal("Amount");
            string category = PromptString("Category");
            string description = PromptString("Description");
            string source = PromptString("Source");

            if (choice == "1")
            {
                bool isBonus = PromptYesNo("Is this a bonus? (y/n)");
                tracker.AddTransaction(new LumpSum(name, amount, category, source, isBonus, description));
            }
            else if (choice == "2")
            {
                int recurringDays = PromptInt("How often is it repeated (in days)?");
                tracker.AddTransaction(new ReoccurringIncome(name, amount, category, description, source, TimeSpan.FromDays(recurringDays)));
            }
            else if (choice == "3")
            {
                int intervalDays = PromptInt("Interval (in days)");
                DateTime startDate = PromptDate("Start date (yyyy-mm-dd)");
                DateTime endDate = PromptDate("End date (yyyy-mm-dd)");
                tracker.AddTransaction(new IntervalIncome(name, amount, category, description, source, startDate, endDate, TimeSpan.FromDays(intervalDays)));
            }

            Console.WriteLine("Income transaction added.");
            break;
        }
    }

    private void CreateExpenseTransaction()
    {
        while (true)
        {
            Console.WriteLine("Choose expense type:");
            Console.WriteLine("1. One-Time");
            Console.WriteLine("2. Recurring");
            Console.WriteLine("3. Interval");
            Console.Write("Select (1-3): ");
            string choice = Console.ReadLine();

            if (!new[] { "1", "2", "3" }.Contains(choice))
            {
                Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                continue;
            }

            string name = PromptString("Name");
            decimal amount = PromptDecimal("Amount");
            string category = PromptString("Category");
            string description = PromptString("Description");

            if (choice == "1")
            {
                tracker.AddTransaction(new OneTimeExpense(category, -Math.Abs(amount), name, description));
            }
            else if (choice == "2")
            {
                int recurringDays = PromptInt("How often is it repeated (in days)?");
                tracker.AddTransaction(new ReoccurringExpense(category, -Math.Abs(amount), name, description, "High", TimeSpan.FromDays(recurringDays)));
            }
            else if (choice == "3")
            {
                int intervalDays = PromptInt("Interval (in days)");
                DateTime startDate = PromptDate("Start date (yyyy-mm-dd)");
                DateTime endDate = PromptDate("End date (yyyy-mm-dd)");
                tracker.AddTransaction(new IntervalExpense(category, -Math.Abs(amount), name, description, startDate, endDate, TimeSpan.FromDays(intervalDays)));
            }

            Console.WriteLine("Expense transaction added.");
            break;
        }
    }

    private string PromptString(string prompt)
    {
        while (true)
        {
            Console.Write($"{prompt}: ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
                return input;
            Console.WriteLine($"Invalid input for {prompt}. Please try again.");
        }
    }

    private decimal PromptDecimal(string prompt)
    {
        while (true)
        {
            Console.Write($"{prompt}: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal value) && value > 0)
                return value;
            Console.WriteLine($"Invalid {prompt}. Please enter a positive decimal.");
        }
    }

    private int PromptInt(string prompt)
    {
        while (true)
        {
            Console.Write($"{prompt}: ");
            if (int.TryParse(Console.ReadLine(), out int value) && value > 0)
                return value;
            Console.WriteLine($"Invalid {prompt}. Please enter a positive integer.");
        }
    }

    private DateTime PromptDate(string prompt)
    {
        while (true)
        {
            Console.Write($"{prompt}: ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime date))
                return date;
            Console.WriteLine("Invalid date format. Please use yyyy-mm-dd.");
        }
    }

    private bool PromptYesNo(string prompt)
    {
        while (true)
        {
            Console.Write($"{prompt} ");
            string input = Console.ReadLine().ToLower();
            if (input == "y" || input == "yes") return true;
            if (input == "n" || input == "no") return false;
            Console.WriteLine("Please enter 'y' or 'n'.");
        }
    }
}