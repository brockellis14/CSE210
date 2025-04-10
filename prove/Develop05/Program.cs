using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("==== Goal Tracker ====");
            Console.WriteLine($"Total Points: {Goal.GetTotalPoints()}");
            Console.WriteLine();
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. Display Goals");
            Console.WriteLine("3. Complete Goal");
            Console.WriteLine("4. Save Goals to File");
            Console.WriteLine("5. Load Goals from File");
            Console.WriteLine("6. Quit");
            Console.Write("Select an option (1-6): ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    GoalManager.CreateGoal();
                    break;

                case "2":
                    Console.WriteLine(Goal.DisplayGoals());
                    Pause();
                    break;

                case "3":
                    GoalManager.CompleteGoal();
                    break;

                case "4":
                    GoalFileManager.SaveGoalsToFile();
                    Pause();
                    break;

                case "5":
                    GoalFileManager.LoadGoalsFromFile();
                    Pause();
                    break;

                case "6":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    Pause();
                    break;
            }
        }
    }

    static void Pause()
    {
        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
    }
}