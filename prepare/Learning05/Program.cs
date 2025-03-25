using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        Shape rectangle1 = new Rectangle("green", 10, 5);
        Console.WriteLine(rectangle1.GetColor());

        Shape circle1 = new Circle("red", 6);
        Console.WriteLine(circle1.GetArea());

        Shape square2 = new Square("yellow", 6);
        Console.WriteLine(square2.GetArea());

    }
}