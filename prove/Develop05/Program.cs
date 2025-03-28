using System;

class Program
{
    static void Main(string[] args)
    {
        Goal goal1 = new Goal("Run 5 miles", "Complete a 5-mile run within the next month", 10);
        Goal goal2 = new Goal("Read 3 books", "Finish reading three books this month", 15);
        Goal goal3 = new Goal("Learn C# basics", "Complete a C# basics course", 20);

        // Display all goals in the goal bank
        Console.WriteLine("Before completing any goals:");
        Console.WriteLine(Goal.DisplayGoals());

        // Complete the first goal
        goal1.CompleteGoal();
        // Complete the second goal
        goal2.CompleteGoal();

        // Display all goals again after completing some
        Console.WriteLine("\nAfter completing some goals:");
        Console.WriteLine(Goal.DisplayGoals());

        // Display total points for a specific goal
        Console.WriteLine("\nTotal points for each goal:");
        Console.WriteLine(goal1.DisplayTotalPoints());
        Console.WriteLine(goal2.DisplayTotalPoints());
        Console.WriteLine(goal3.DisplayTotalPoints());
    }
}