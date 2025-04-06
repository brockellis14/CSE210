using System;

class Program
{
    static void Main(string[] args)
    {
        // Create some transactions
        LumpSum lumpSumTransaction = new LumpSum(
            DateTime.Now, 1000, "Bonus", "Year-end bonus", "Employer A", true);

        ReoccurringIncome reoccurringIncome = new ReoccurringIncome(
            DateTime.Now, 500, "Salary", "Monthly salary", "Employer B", TimeSpan.FromDays(30));

        IntervalIncome intervalIncome = new IntervalIncome(
            DateTime.Now, 1500, "Contract", "Contract work payment", "Company X", TimeSpan.FromDays(90), DateTime.Now.AddMonths(3));

        // Display transactions
        lumpSumTransaction.DisplayTransaction();
        reoccurringIncome.DisplayTransaction();
        intervalIncome.DisplayTransaction();
        
    }
}
