public class Program
{
    public static void Main(string[] args)
    {
        decimal goal = 0;
        string reportFileName = "report.txt";

        var tracker = new FinancialTracker(goal);
        var report = new Report(reportFileName, goal);

        var menu = new Menu(tracker, report, reportFileName);
        menu.DisplayMenu();
    }
}
