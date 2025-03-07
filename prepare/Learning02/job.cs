using System;

public class Job
{
    private string _jobTitle;
    private string _company;
    private int _startYear;
    private int _endYear;

    public Job(string title, string company, int start, int end)
    {
        _jobTitle = title;
        _company = company;
        _startYear = start;
        _endYear = end;

    }
    public void DisplayJob()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
