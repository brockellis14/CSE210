using System.Formats.Asn1;

class Circle
{
    private double radius;

    public Circle(double r)
    {
        radius = r;
    }

    public  double GetArea()
    {
        double area = radius * radius * Math.PI;
        return area;
    }

    public void DisplayCircleArea()
    {
        Console.WriteLine($"The area of the circle is {GetArea()}");
    }

}