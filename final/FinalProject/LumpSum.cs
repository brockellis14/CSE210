public class LumpSum : Income
{
    private bool _isBonus;

    public LumpSum(DateTime date, float amount, string category, string description, string source, bool isBonus)
        : base(date, amount, category, description, source)
    {
        _isBonus = isBonus;
    }

    public override void DisplayTransaction()
    {
        Console.WriteLine($"LumpSum - Date: {_dateTime}, Amount: {_amount}, Category: {_category}, Description: {_description}, Source: {GetSource()}, Bonus: {_isBonus}");
    }
}