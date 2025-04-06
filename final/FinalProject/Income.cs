public abstract class Income : Transaction
{
    private string _source;

    public Income(DateTime date, float amount, string category, string description, string source)
        : base(date, amount, category, description)
    {
        _source = source;
    }

    public string GetSource()
    {
        return _source;
    }

    // Abstract method for displaying the transaction details, to be implemented in subclasses
    public abstract override void DisplayTransaction();
}