using System;

public static class TransactionFactory
{
    public static Transaction CreateTransaction()
    {
        while (true)
        {
            Console.Write("Enter transaction type (income/expense): ");
            string type = Console.ReadLine()?.ToLower();

            if (type == "income") return CreateIncomeTransaction();
            if (type == "expense") return CreateExpenseTransaction();

            Console.WriteLine("❌ Invalid transaction type. Please enter 'income' or 'expense'.");
        }
    }

    private static Transaction CreateIncomeTransaction()
    {
        while (true)
        {
            Console.WriteLine("Choose income type:");
            Console.WriteLine("1. LumpSum");
            Console.WriteLine("2. Recurring");
            Console.WriteLine("3. Interval");

            string choice = PromptHelper.PromptString("Select (1-3)");

            if (choice is not ("1" or "2" or "3"))
            {
                Console.WriteLine("❌ Invalid selection. Please enter 1, 2, or 3.");
                continue;
            }

            string name = PromptHelper.PromptString("Name");
            decimal amount = PromptHelper.PromptDecimal("Amount");
            string category = PromptHelper.PromptString("Category");
            string description = PromptHelper.PromptString("Description");
            string source = PromptHelper.PromptString("Source");

            try
            {
                return choice switch
                {
                    "1" => new LumpSum(name, amount, category, source,
                        PromptHelper.PromptYesNo("Is this a bonus? (y/n)"), description),
                    "2" => new ReoccurringIncome(name, amount, category, description, source,
                        TimeSpan.FromDays(PromptHelper.PromptInt("Repeat interval (days)"))),
                    "3" => new IntervalIncome(name, amount, category, description, source,
                        PromptHelper.PromptDate("Start date (yyyy-mm-dd)"),
                        PromptHelper.PromptDate("End date (yyyy-mm-dd)"),
                        TimeSpan.FromDays(PromptHelper.PromptInt("Interval (days)"))),
                    _ => throw new InvalidOperationException("Unexpected selection.")
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Failed to create income transaction: {ex.Message}");
            }
        }
    }

    private static Transaction CreateExpenseTransaction()
    {
        while (true)
        {
            Console.WriteLine("Choose expense type:");
            Console.WriteLine("1. One-Time");
            Console.WriteLine("2. Recurring");
            Console.WriteLine("3. Interval");

            string choice = PromptHelper.PromptString("Select (1-3)");

            if (choice is not ("1" or "2" or "3"))
            {
                Console.WriteLine("❌ Invalid selection. Please enter 1, 2, or 3.");
                continue;
            }

            string name = PromptHelper.PromptString("Name");
            decimal amount = -Math.Abs(PromptHelper.PromptDecimal("Amount"));
            string category = PromptHelper.PromptString("Category");
            string description = PromptHelper.PromptString("Description");

            try
            {
                return choice switch
                {
                    "1" => new OneTimeExpense(category, amount, name, description),
                    "2" => new ReoccurringExpense(category, amount, name, description,
                        "High", TimeSpan.FromDays(PromptHelper.PromptInt("Repeat interval (days)"))),
                    "3" => new IntervalExpense(category, amount, name, description,
                        PromptHelper.PromptDate("Start date (yyyy-mm-dd)"),
                        PromptHelper.PromptDate("End date (yyyy-mm-dd)"),
                        TimeSpan.FromDays(PromptHelper.PromptInt("Interval (days)"))),
                    _ => throw new InvalidOperationException("Unexpected selection.")
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Failed to create expense transaction: {ex.Message}");
            }
        }
    }
}
