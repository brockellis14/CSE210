public class OneTimeExpense : Expense
{
    public OneTimeExpense(DateTime date, float amount, string category, string description, string necessity)
        : base(date, amount, category, description, necessity)
    {}

    public override void DisplayTransaction()
    {
        Console.WriteLine($"One-time Expense: {GetCategory()}, Amount: ${GetAmount()}, Necessity: {GetNecessityLevel()}");
    }
}