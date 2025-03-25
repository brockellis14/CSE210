using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        Shape shape1 = new Shape("green");
        Console.WriteLine(shape1.GetColor());
        shape1.SetColor("yellow");
        Console.WriteLine(shape1.GetColor());

    }
}