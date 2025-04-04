public abstract class Expense: Transaction
{
    private string _necessityLevel;

    public Expense(DateTime date, float amount, string category, string description, string necessity)
    : base(date, amount, category, description)
    {
        _necessityLevel = necessity;
    }

    public string GetNecessityLevel()
    {
        return _necessityLevel;
    }

    public abstract override void DisplayTransaction()
    {
        
    }
}
