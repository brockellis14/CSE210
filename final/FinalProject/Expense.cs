public class Expense : Transaction
{
    public string Description { get; set; }

    public Expense(string category, decimal amount, string name, string description, DateTime? date = null)
        : base(category, amount, name, date)
    {
        Description = description;
    }

    public override string GetCategory()
    {
        return base.Category;
    }

    public string GetDescription()
    {
        return Description;
    }
}
