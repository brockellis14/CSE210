public abstract class Income : Transaction
{
    protected string Source { get; set; }
    protected bool IsRecurring { get; set; }
    protected string Description { get; set; }

    public Income(decimal amount, string category, string name, string source, bool isRecurring, string description = "", DateTime? date = null)
        : base(category, amount, name, date)
    {
        Source = source;
        IsRecurring = isRecurring;
        Description = description;
    }

    public string GetSource()
    {
        return Source;
    }

    public override string GetCategory()
    {
        return base.Category;
    }
}
