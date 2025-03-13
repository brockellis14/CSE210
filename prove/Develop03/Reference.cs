class ScriptureReference
{
    private Dictionary<string, Scripture> _scripturesBank;
    private string _reference;
    private Scripture _selectedScripture;

    public ScriptureReference()
    {
        _scripturesBank = new Dictionary<string, Scripture>
        {
            { "Moroni 10:32", new Scripture("Moroni", 10, 32, "Yea, come unto Christ, and be perfected in him...") },
            { "2 Nephi 2:11", new Scripture("2 Nephi", 2, 11, "For it must needs be, that there is an opposition in all things...") },
            { "Mosiah 2:17", new Scripture("Mosiah", 2, 17, "And behold, I tell you these things that ye may learn wisdom...") }
        };

        _reference = "";
    }

    public void SetReference()
    {
        List<string> keys = new List<string>(_scripturesBank.Keys);
        Console.WriteLine("Available Scriptures:");
        for (int i = 0; i < keys.Count; i++)
        {
            Console.WriteLine($"{i + 1}: {keys[i]}");
        }

        Console.Write("Please enter a number (1, 2, or 3): ");
        if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= keys.Count)
        {
            _reference = keys[choice - 1];
            _selectedScripture = _scripturesBank[_reference];

            Console.WriteLine("\nYou selected:");
            _selectedScripture.DisplayScripture();
        }
        else
        {
            Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
        }
    }

    public Scripture GetScripture()
    {
        return _selectedScripture;
    }

    public string GetReference()
    {
        return _reference;
    }

    public void DisplayReference()
    {
        Console.WriteLine($"Selected Reference: {_reference}");
    }
}
