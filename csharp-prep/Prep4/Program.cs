using System;

class Program
{
    static void Main(string[] args)
    {
       List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, one at a time, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number == 0)
                    break;
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
            }
        }

        if (numbers.Count > 0)
        {
            int sum = 0;
            int max = numbers[0];
            int? smallestPositive = null;

            foreach (int num in numbers)
            {
                sum += num;
                if (num > max)
                    max = num;
                if (num > 0 && (smallestPositive == null || num < smallestPositive))
                    smallestPositive = num;
            }

            double average = (double)sum / numbers.Count;

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {max}");
            
            if (smallestPositive.HasValue)
                Console.WriteLine($"The smallest positive number is: {smallestPositive}");

            numbers.Sort();
            Console.WriteLine("The sorted list is:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}