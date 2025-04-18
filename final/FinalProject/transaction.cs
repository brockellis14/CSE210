public abstract class Transaction
{
    protected string Name { get; set; }
    protected decimal Amount { get; set; }
    protected DateTime Date { get; set; }
    protected string Category { get; set; }

    // Constructor to initialize values, now with DateTime.Now default
    public Transaction(string category, decimal amount, string name, DateTime? date = null) // makes it optional for date
    {
        Category = category;
        Name = name;
        Amount = amount;
        Date = date ?? DateTime.Now;  // Automatically set to current date and time if no date is provided
    }

    // Virtual method to allow overriding in derived classes
    public virtual string DisplayTransaction()
    {
        return $"Transaction: {Name}, Amount: ${Amount}, Date: {Date}";
    }

    public DateTime GetDate()
    {
        return Date;
    }

    public decimal GetAmount()
    {
        return Amount;
    }

    // Marked as virtual to allow overriding in derived classes 
    public virtual string GetTransactionDetails()
    {
        return $"{Name} | {Amount} | {Date.ToShortDateString()}";
    }

    // Virtual GetCategory method to be overridden in derived classes
    public virtual string GetCategory()
    {
        return Category;
    }
}