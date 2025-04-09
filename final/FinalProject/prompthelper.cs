using System;

public static class PromptHelper
{
    public static string PromptString(string prompt)
    {
        while (true)
        {
            Console.Write($"{prompt}: ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
                return input;
            Console.WriteLine($"Invalid input for {prompt}. Please try again.");
        }
    }

    public static decimal PromptDecimal(string prompt)
    {
        while (true)
        {
            Console.Write($"{prompt}: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal value) && value > 0)
                return value;
            Console.WriteLine($"Invalid {prompt}. Please enter a positive decimal.");
        }
    }

    public static int PromptInt(string prompt)
    {
        while (true)
        {
            Console.Write($"{prompt}: ");
            if (int.TryParse(Console.ReadLine(), out int value) && value > 0)
                return value;
            Console.WriteLine($"Invalid {prompt}. Please enter a positive integer.");
        }
    }

    public static DateTime PromptDate(string prompt)
    {
        while (true)
        {
            Console.Write($"{prompt}: ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime date))
                return date;
            Console.WriteLine("Invalid date format. Please use yyyy-mm-dd.");
        }
    }

    public static bool PromptYesNo(string prompt)
    {
        while (true)
        {
            Console.Write($"{prompt} ");
            string input = Console.ReadLine().ToLower();
            if (input == "y" || input == "yes") return true;
            if (input == "n" || input == "no") return false;
            Console.WriteLine("Please enter 'y' or 'n'.");
        }
    }
}