
public class GoalManager
{
    // Handles creating a new goal
    public static void CreateGoal()
    {
        Console.WriteLine("Select Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choice: ");
        string choice = Console.ReadLine();

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Description: ");
        string description = Console.ReadLine();

        int points = GetValidInteger("Enter Points: ");

        switch (choice)
        {
            case "1":
                new SimpleGoal(name, description, points);
                break;
            case "2":
                new EternalGoal(name, description, points);
                break;
            case "3":
                int target = GetValidInteger("Enter Target Completions: ");
                int bonus = GetValidInteger("Enter Bonus Points: ");
                new CheckListGoal(name, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    // Handles completing a goal
    public static void CompleteGoal()
    {
        Console.WriteLine(Goal.DisplayGoals());
        Console.Write("Enter goal number to complete: ");

        if (int.TryParse(Console.ReadLine(), out int goalNum))
        {
            List<Goal> goals = Goal.GetGoals();

            if (goalNum >= 1 && goalNum <= goals.Count)
            {
                goals[goalNum - 1].CompleteGoal();
                Console.WriteLine("Goal completed!");
            }
            else
            {
                Console.WriteLine("Invalid goal number.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        Pause();
    }

    // Helper Method to Validate Integer Input
    private static int GetValidInteger(string prompt)
    {
        int result;
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if (int.TryParse(input, out result) && result >= 0)
            {
                return result;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid non-negative number.");
            }
        }
    }

    private static void Pause()
    {
        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
    }
}
