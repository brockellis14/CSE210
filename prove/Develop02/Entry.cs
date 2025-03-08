using System;

class Entry
{
    private string _currentDate;
    private string _prompt;
    private string _response;
    private static List<string> prompts = new List<string>
    {
        "What was the highlight of your day?",
        "What is something new you learned today?",
        "What are you grateful for today?",
        "Describe a moment that made you smile today."
    };

    public Entry(string response)
    {
        _currentDate = DateTime.Now.ToString("yyyy-MM-dd");
        _prompt = prompts[new Random().Next(prompts.Count)];
        _response = response;
    }

    public string GetPrompt()
    {
        return _prompt;
    }

    public string GetFormattedEntry()
    {
        return $"{_currentDate}: {_prompt} {_response}";
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"{_currentDate}# {_prompt}# {_response}");
    }
}
