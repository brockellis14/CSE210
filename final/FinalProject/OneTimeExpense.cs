public class OneTimeExpense : Expense
{
    public new string Category { get; set; }

    public OneTimeExpense(string category, decimal amount, string name, string description, DateTime? date = null)
        : base(category, amount, name, description, date ?? DateTime.Now)
    {
        Category = category;
    }

    public override string GetTransactionDetails()
    {
        return $"{Name} | {Amount} | {Date.ToShortDateString()} | {Category}";
    }

    public new string GetCategory()
    {
        return Category;
    }

    public override string DisplayTransaction()
    {
        return $"OneTime Expense: {Name}, Amount: ${Amount}, Description: {Description} Date: {Date}, Category: {Category}";
    }
}
