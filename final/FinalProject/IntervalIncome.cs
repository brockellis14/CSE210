public class IntervalIncome : Income
{
    private TimeSpan _interval;
    private DateTime _endDate;

    public IntervalIncome(string name, decimal amount, string category, string description, string source, TimeSpan interval, DateTime endDate, DateTime? date = null)
        : base(amount, category, name, source, true, description, date)
    {
        _interval = interval;
        _endDate = endDate;
    }

    public TimeSpan GetInterval()
    {
        return _interval;
    }

    public DateTime GetEndDate()
    {
        return _endDate;
    }

    public override string DisplayTransaction()
    {
        return $"Interval Income: {GetCategory()}, Amount: ${Amount}, Source: {GetSource()}, Description: {Description} Interval: {_interval.Days} days, Ends: {_endDate.ToShortDateString()}";
    }
}
