using System;

class Program
{
    static void Main()
    {
        ScriptureReference scriptureReference = new ScriptureReference();

        scriptureReference.SetReference();

        Scripture selectedScripture = scriptureReference.GetScripture();
        if (selectedScripture != null)
        {
            selectedScripture.DisplayScripture();
        }
        else
        {
            Console.WriteLine("No scripture selected.");
        }
        scriptureReference.DisplayReference();
    }
}