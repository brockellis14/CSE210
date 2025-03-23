using System;

public class ListingActivity : MindfulnessActivity
{
    // Overriding the PerformActivity method
    public override void PerformActivity()
    {
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.WriteLine("Starting listing activity...");

        // Example of asking for duration
        Console.Write("Enter the duration (in seconds): ");
        int duration = int.Parse(Console.ReadLine());
        Duration = duration;

        Console.WriteLine("Get ready to list...");
        Thread.Sleep(2000);  // Short pause

        // Simulate listing activity
        string[] prompts = {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "What things have you done for yourself today?",
            "What are the things you want to happen within 3-5 years?",
            "What are the colors you see around you?",
            "What can you hear around you?",
            "What can you feel when you close your eyes?"
        };

        Random rand = new Random();
        for (int i = 0; i < duration; i = i + 12)
        {
            int index = rand.Next(prompts.Length);
            Console.WriteLine(prompts[index]);

            // Give the user a few seconds to think and list items
            Thread.Sleep(12000);
        }

        Console.WriteLine("Well done! You've completed your listing activity.");
    }
}
