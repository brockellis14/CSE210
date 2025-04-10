
public class GoalFileManager
{
    // Write all goals to a file
    public static void SaveGoalsToFile()
    {
        List<Goal> goals = Goal.GetGoals();
        
        Console.Write("Enter filename to load (must end in .txt): ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Goal goal in goals)
            {
                outputFile.WriteLine(goal.DisplayGoal());
            }
        }

        Console.WriteLine($"Goals saved to {filename}");
    }

    // Read goals from a file (just display for now)
    public static void LoadGoalsFromFile()
    {
        Console.Write("Enter filename to load (must end in .txt): ");
        string filename = Console.ReadLine();

        if (!filename.EndsWith(".txt"))
        {
            Console.WriteLine("Error: Must be a .txt file.");
            return;
        }

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);

            Console.WriteLine($"\nContents of {filename}:");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
