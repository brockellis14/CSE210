public class ReoccurringIncome : Income
{
    private TimeSpan _interval;

    public ReoccurringIncome(string name, decimal amount, string category, string description, string source, TimeSpan interval, DateTime? date = null)
        : base(amount, category, name, source, true, description, date)
    {
        _interval = interval;
    }

    public TimeSpan GetInterval()
    {
        return _interval;
    }

    public override string DisplayTransaction()
    {
        return $"Reoccurring Income: {GetCategory()}, Amount: ${Amount}, Source: {Source}, Description: {Description} Interval: {_interval.Days} days";
    }
}
