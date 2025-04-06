public class IntervalIncome : Income
{
    private TimeSpan _interval;  // Interval for the income
    private DateTime _endDate;   // End date of the interval

    public IntervalIncome(DateTime date, float amount, string category, string description, string source, TimeSpan interval, DateTime endDate)
        : base(date, amount, category, description, source)
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

    public override void DisplayTransaction()
    {
        Console.WriteLine($"Interval Income: {GetCategory()}, Amount: ${GetAmount()}, Source: {GetSource()}, Interval: {_interval.Days} days, Ends: {_endDate.ToShortDateString()}");
    }
}