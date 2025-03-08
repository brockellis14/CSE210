using System;

    class program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> menu = new Dictionary<int, string>
            {
                { 1, "Create Entry" },
                { 2, "Display Journal" },
                { 3, "Write to a file" },
                { 4, "Read from a file" },
                { 5, "Quit" }
            };

            List<Entry> entries = new List<Entry>();
            int answer = 0;

            while (answer != 5)
            {
                Console.WriteLine("Choose from the following by entering an integer:");
                foreach (var item in menu)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }

                if (!int.TryParse(Console.ReadLine(), out answer))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                if (answer == 1)
                {
                    Entry newEntry = new Entry("");
                    Console.WriteLine($"Prompt: {newEntry.GetPrompt()}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    newEntry = new Entry(response);
                    entries.Add(newEntry);
                }
    
                else if (answer == 2)
                {
                    Console.WriteLine("Journal Entries:");
                    foreach (var entry in entries)
                    {
                        entry.DisplayEntry();
                    }
                }
                else if (answer == 3)
                {
                    Console.WriteLine("Please enter a file name: ");
                    string fileName = Console.ReadLine();

                    WriteToFile file = new WriteToFile(fileName);
                    file.SaveEntries(entries);

                    Console.WriteLine($"New file saved as {fileName}.txt");
                }

                else if (answer == 4)
                {
                    Console.WriteLine("Please enter a file name: ");
                    string filename = Console.ReadLine();
                    ReadFile readFile = new ReadFile($"{filename}");
                    readFile.LoadEntries();
                }
                else if (answer == 5)
                {
                    Console.WriteLine("Goodbye!");
                }
                else
                {
                    Console.WriteLine("Invalid option. Please try again.");
                }
            }
        }
    }

