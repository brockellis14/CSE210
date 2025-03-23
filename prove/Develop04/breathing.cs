using System;

public class BreathingActivity : MindfulnessActivity
{
    // Overriding the PerformActivity method
    public override void PerformActivity()
    {
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly.");
        Console.WriteLine("Starting breathing activity...");

        // Example of asking for duration
        Console.Write("Enter the duration (in seconds): ");
        int duration = int.Parse(Console.ReadLine());
        Duration = duration;

        Console.WriteLine("Get ready to start...");
        Thread.Sleep(2000);  // Short pause

        // Simulate breathing activity
        for (int i = 0; i < duration; i = i + 15)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(1000);
            Console.Write(6);
            Thread.Sleep(1000);
            Console.Write(5);
            Thread.Sleep(1000);
            Console.Write(4);
            Thread.Sleep(1000);
            Console.Write(3);
            Thread.Sleep(1000);
            Console.Write(2);
            Thread.Sleep(1000);
            Console.WriteLine(1);
            Thread.Sleep(1000);
            Console.WriteLine("Breathe out...");
            Thread.Sleep(1000);
            Console.Write(6);
            Thread.Sleep(1000);
            Console.Write(5);
            Thread.Sleep(1000);
            Console.Write(4);
            Thread.Sleep(1000);
            Console.Write(3);
            Thread.Sleep(1000);
            Console.Write(2);
            Thread.Sleep(1000);
            Console.WriteLine(1);
            Thread.Sleep(1000);
        }

        Console.WriteLine("Well done! You've completed your breathing activity.");
    }
}
