public class IntervalExpense : Expense
{
    private new string Category;
    private DateTime _startDate;
    private DateTime _endDate;
    private TimeSpan _interval;

    public IntervalExpense(string category, decimal amount, string name, string description, DateTime startDate, DateTime endDate, TimeSpan interval)
        : base(category, amount, name, description, startDate)
    {
        _startDate = startDate;
        _endDate = endDate;
        _interval = interval;
        Category = category;
    }

    public override string GetTransactionDetails()
    {
        return $"{Name} | ${Amount} | {Category} | Start: {_startDate.ToShortDateString()} | End: {_endDate.ToShortDateString()} | Every {_interval.Days} days";
    }

    public override string DisplayTransaction()
    {
        return $"Interval Expense: {Name}, Amount: ${Amount}, Start: {_startDate}, End: {_endDate}, Interval: {_interval.Days} days, Description: {Description}, Category: {Category}";
    }
}
