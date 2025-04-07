public class LumpSum : Income
{
    private bool _isBonus;

    public LumpSum(string name, decimal amount, string category, string source, bool isBonus, string description = "", DateTime? date = null)
        : base(amount, category, name, source, false, description, date)
    {
        _isBonus = isBonus;
    }

    public override string DisplayTransaction()
    {
        return $"LumpSum - Date: {Date}, Amount: ${Amount}, Category: {GetCategory()}, Description: {Description}, Source: {Source}, Bonus: {_isBonus}";
    }

    public bool GetIsBonus()
    {
        return _isBonus;
    }
}
