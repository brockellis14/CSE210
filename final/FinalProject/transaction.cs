public abstract class Transaction
{
    protected DateTime _dateTime;
    protected float _amount;
    protected string _category;
    protected string _description;

    public Transaction(DateTime date, float amount, string category, string description)
    {
        _dateTime = date;
        _amount = amount;
        _category = category;
        _description = description;
    }

    public float GetAmount()
    {
        return _amount;
    }

    public string GetCategory()
    {
        return _category;
    }

    public string GetDescription()
    {
        return _description;
    }

    public abstract void DisplayTransaction()
    {
        
    }
}