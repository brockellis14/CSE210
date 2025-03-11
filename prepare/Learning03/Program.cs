using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction fraction = new Fraction(8, 0);
        Console.WriteLine(fraction.GetFractionString());
    }
}