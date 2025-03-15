using System;

class Program
{
    static void Main()
    {
        ScriptureReference scriptureReference = new ScriptureReference();

        // Step 1: User selects a scripture
        scriptureReference.SetReference();
        Scripture selectedScripture = scriptureReference.GetScripture();

        if (selectedScripture == null)
        {
            Console.WriteLine("No scripture selected. Exiting program.");
            return;
        }

        Console.Clear();
        Console.WriteLine("You have selected:");
        selectedScripture.DisplayScripture();
        
        // Step 2: Loop for user interaction
        while (!selectedScripture.AllWordsHidden())
        {
            Console.WriteLine("\nOptions:");
            Console.WriteLine("[H] Hide words");
            Console.WriteLine("[Enter] Refresh scripture");
            Console.WriteLine("[Q] Quit");

            string input = Console.ReadLine().ToLower();

            if (input == "q") 
            {
                Console.WriteLine("Exiting program...");
                break;
            }
            else if (input == "h")
            {
                selectedScripture.HideRandomWords(2); // Hide 2 words at a time
            }

            Console.Clear();
            selectedScripture.DisplayScripture();
        }

        Console.WriteLine("All words are now hidden or you've exited.");
    }
}
