class ScriptureReference
{
    private Dictionary<string, Scripture> _scripturesBank;
    private string _reference;
    private Scripture _selectedScripture;

    public ScriptureReference()
    {
        _scripturesBank = new Dictionary<string, Scripture>
        {
            { "Moroni 10:32", new Scripture("Moroni", 10, 32, "Yea, come unto Christ, and be perfected in him, and deny yourselves of all ungodliness; and if ye shall deny yourselves of all ungodliness, and love God with all your might, mind and strength, then is his grace sufficient for you, that by his grace ye may be perfect in Christ; and if by the grace of God ye are perfect in Christ, ye can in nowise deny the power of God.") },
            { "2 Nephi 2:11", new Scripture("2 Nephi", 2, 11, "For it must needs be, that there is an opposition in all things. If not so, my firstborn in the wilderness, righteousness could not be brought to pass, neither wickedness, neither holiness nor misery, neither good nor bad. Wherefore, all things must needs be a compound in one; wherefore, if it should be one body it must needs remain as dead, having no life neither death, nor corruption nor incorruption, happiness nor misery, neither sense nor insensibility.") },
            { "Mosiah 2:17", new Scripture("Mosiah", 2, 17, "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God.") }
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
