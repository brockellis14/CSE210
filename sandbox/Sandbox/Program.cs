using System;

class Program
{
    static void Main(string[] args)
    {
        // List<int> numbers = new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        // numbers.Add(10);

        // foreach(int x in numbers)
        // {
        //     Console.WriteLine($"{x}");
        // }

        // bool correctInput = false;
        // while(!correctInput)
        // {
        //     Console.WriteLine("Please input your age: ");
        //     int age = int.Parse(Console.ReadLine());
        //     if (age >= 0 && age < 120)
        //     {
        //         Console.WriteLine($"Your age is: {age}");
        //         correctInput = true;
        //     }
        // }
        // bool correctInput;
        // do
        // {
        //     Console.WriteLine("Please input your age: ");
        //     int age = int.Parse(Console.ReadLine());
        //     if (age >= 0 && age < 120)
        //     {
        //         Console.WriteLine($"Your age is: {age}");
        //         correctInput = true;
        //     }
        //     else
        //     correctInput = false;
        // }while(!correctInput);
        
        Random newRandomNumber = new Random();
        for(int i = 1; i< 100; i++)
        {
        int number = newRandomNumber.Next(1, 1000);
        Console.WriteLine($"{i}: {number}");
        }
    }
}