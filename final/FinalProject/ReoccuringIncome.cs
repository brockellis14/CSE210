public class ReoccurringIncome : Income
{
    private TimeSpan _interval;  // Interval for the reoccurring income

    public ReoccurringIncome(DateTime date, float amount, string category, string description, string source, TimeSpan interval)
        : base(date, amount, category, description, source)
    {
        _interval = interval;
    }

    public TimeSpan GetInterval()
    {
        return _interval;
    }

    public override void DisplayTransaction()
    {
        Console.WriteLine($"Reoccurring Income: {GetCategory()}, Amount: ${GetAmount()}, Source: {GetSource()}, Interval: {_interval.Days} days");
    }
}