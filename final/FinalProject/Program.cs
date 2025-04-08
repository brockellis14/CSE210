public class Program
{
    public static void Main(string[] args)
    {
        var bank = new TransactionBank();
        decimal goal = 0;
        var tracker = new FinancialTracker(bank, goal);
        string reportFileName = "report.txt";
        var report = new Report(bank, reportFileName, goal);

        var menu = new Menu(tracker, bank, report, reportFileName);
        menu.DisplayMenu();
    }
}
