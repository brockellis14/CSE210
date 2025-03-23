using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Show the main menu
        ShowMenu();
    }

    public static void ShowMenu()
    {
        bool keepRunning = true;

        while (keepRunning)
        {
            // Displaying the menu
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine("Please choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            // Perform the selected activity
            switch (choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.PerformActivity();
                    break;
                case "2":
                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    reflectionActivity.PerformActivity();
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.PerformActivity();
                    break;
                case "4":
                    keepRunning = false;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }

            // Wait for user input before showing the menu again
            if (keepRunning)
            {
                Console.WriteLine("\nPress any key to return to the main menu.");
                Console.ReadKey();
            }
        }
    }
}
