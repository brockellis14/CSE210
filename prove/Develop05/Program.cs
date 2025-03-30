using System;

class Program
{
    static void Main(string[] args)
    {
        SimpleGoal simpleGoal = new SimpleGoal("Run a Marathon", "By the end of the year", 100);
        EternalGoal eternalGoal = new EternalGoal("Exercise Daily", "Exercise every day for a year", 5);
        CheckListGoal checklistGoal = new CheckListGoal("Run 5 miles Twice", "Complete the project 10 times", 20, 10, 50);

        // Display goals
        Console.WriteLine("Goals before completing any:");
        Console.WriteLine(Goal.DisplayGoals());

        // Complete goals
        simpleGoal.CompleteGoal();
        eternalGoal.CompleteGoal();
        checklistGoal.CompleteGoal();

        // Display updated goals
        Console.WriteLine("\nGoals after completing some:");
        Console.WriteLine(Goal.DisplayGoals());
    }
}