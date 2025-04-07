public class ReoccurringExpense : Expense
{
    private TimeSpan _interval;

    public ReoccurringExpense(string category, decimal amount, string name, string description, string necessity, TimeSpan interval, DateTime? date = null)
        : base(category, amount, name, description, date ?? DateTime.Now)
    {
        _interval = interval;
    }

    public TimeSpan GetInterval()
    {
        return _interval;
    }

    public override string DisplayTransaction()
    {
        return $"Reoccurring Expense: {GetCategory()}, Amount: ${Amount}, Description: {Description} Interval: {_interval.Days} days";
    }
}
