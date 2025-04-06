public class ReoccurringExpense : Expense
{
    private TimeSpan _interval;  // Interval for the reoccurring expense

    public ReoccurringExpense(DateTime date, float amount, string category, string description, string necessity, TimeSpan interval)
        : base(date, amount, category, description, necessity)
    {
        _interval = interval;
    }

    public TimeSpan GetInterval()
    {
        return _interval;
    }

    public override void DisplayTransaction()
    {
        Console.WriteLine($"Reoccurring Expense: {GetCategory()}, Amount: ${GetAmount()}, Necessity: {GetNecessityLevel()}, Interval: {_interval.Days} days");
    }
}