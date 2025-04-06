public class IntervalExpense : Expense
{
    private TimeSpan _interval;  // Interval for the expense
    private DateTime _endDate;   // End date of the interval

    public IntervalExpense(DateTime date, float amount, string category, string description, string necessity, TimeSpan interval, DateTime endDate)
        : base(date, amount, category, description, necessity)
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
        Console.WriteLine($"Interval Expense: {GetCategory()}, Amount: ${GetAmount()}, Necessity: {GetNecessityLevel()}, Interval: {_interval.Days} days, Ends: {_endDate.ToShortDateString()}");
    }
}