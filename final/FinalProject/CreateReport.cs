public class Report : FinancialTracker
{
    private string _filePath;

    public class Report(string filePath)
    {
        _filePath = filePath;
    }
    
    public abstract void CreateReport(List<Transaction> transactions)
    {

    }
    public abstract void ReadReport()
    {

    }
    public string CheckYTDProgress(List<Transaction> transactions)
    {

    }


}