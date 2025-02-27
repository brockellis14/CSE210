using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        bool answer = false;
        
        // Generate random number
        Random newRandomNumber = new Random();
        int magic = newRandomNumber.Next(1, 100);
        int x = 0;

        // Start guessing loop
        while (!answer)
        {
            Console.Write("Make a guess: ");
            int guess = int.Parse(Console.ReadLine());
            ++x;

            if (guess < magic)
            {
                Console.WriteLine("Your guess is too low!");
            }
            else if (guess > magic)
            {
                Console.WriteLine("Your guess is too high!");
            }
            else
            {
                Console.WriteLine($"Congrats, you guessed correctly, with a total of {x} guesses!");
                answer = true;
            }
        }
    }
}
