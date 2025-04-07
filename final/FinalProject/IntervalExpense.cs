public class IntervalExpense : Expense
{
    public new string Category { get; set; }

    public IntervalExpense(string category, decimal amount, string name, string description, DateTime? date = null)
        : base(category, amount, name, description, date ?? DateTime.Now)
    {
        Category = category;
    }

    public override string GetTransactionDetails()
    {
        return $"{Name} | {Amount} | {Date.ToShortDateString()} | Category: {Category}";
    }

    public override string DisplayTransaction()
    {
        return $"Interval Expense: {Name}, Amount: ${Amount}, Description: {Description} Date: {Date}, Category: {Category}";
    }
}
