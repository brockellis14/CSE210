using System;

public class ReflectionActivity : MindfulnessActivity
{
    // Overriding the PerformActivity method
    public override void PerformActivity()
    {
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience.");
        Console.WriteLine("Starting reflection activity...");

        // Example of asking for duration
        Console.Write("Enter the duration (in seconds): ");
        int duration = int.Parse(Console.ReadLine());
        Duration = duration;

        Console.WriteLine("Get ready to reflect...");
        Thread.Sleep(2000);  // Short pause

        // Simulate reflection activity
        string[] prompts = {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time you were proud of yourself",
            "Think of the last time you laughed",
            "Think of a time when you were happy",
            "Think of a time when you did a hobby"
        };

        Random rand = new Random();
        for (int i = 0; i < duration; i = i + 10)
        {
            int index = rand.Next(prompts.Length);
            Console.WriteLine(prompts[index]);

            // Simulate user reflection with a pause
            Thread.Sleep(10000);  // Short pause
        }

        Console.WriteLine("Well done! You've completed your reflection activity.");
    }
}
