using System;
using System.Data;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Your Grade Percentage: ");

        int grade;
        bool isValid = int.TryParse(Console.ReadLine(), out grade);

        if (!isValid || grade < 0 || grade > 100) 
        {
            Console.WriteLine("Invalid input! Please enter a percentage between 0 and 100.");
            return;
        }

        string letter;

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine the grade sign (+, -, or neutral)
        string sign = "";
        int lastDigit = grade % 10; // Extract the ones place

        if (grade >= 60 && grade < 97) // Only apply signs from A to D
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        if (grade >= 70)
        {
            Console.WriteLine($"Congratulations, you passed this class with a {letter}{sign}!");
        }
        else
        {
            Console.WriteLine($"Sorry, you did not pass with a {letter}{sign}. Try harder next time!");
        }
    }
}
