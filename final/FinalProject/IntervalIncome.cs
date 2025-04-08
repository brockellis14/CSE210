public class IntervalIncome : Income
{
    private DateTime _startDate;
    private DateTime _endDate;
    private TimeSpan _interval;

    public IntervalIncome(string name, decimal amount, string category, string description, string source,
        DateTime startDate, DateTime endDate, TimeSpan interval, DateTime? date = null)
        : base(amount, category, name, source, true, description, date ?? startDate)
    {
        _startDate = startDate;
        _endDate = endDate;
        _interval = interval;
    }

    public DateTime GetStartDate() => _startDate;
    public DateTime GetEndDate() => _endDate;
    public TimeSpan GetInterval() => _interval;

    public override string DisplayTransaction()
    {
        return $"Interval Income: {Name}, Amount: ${Amount}, Start: {_startDate.ToShortDateString()}, End: {_endDate.ToShortDateString()}, Every {_interval.Days} days, Source: {Source}, Description: {Description}";
    }

    public override string GetTransactionDetails()
    {
        return $"{Name} | ${Amount} | Interval | Start: {_startDate.ToShortDateString()} | End: {_endDate.ToShortDateString()} | Every {_interval.Days} days";
    }
}
