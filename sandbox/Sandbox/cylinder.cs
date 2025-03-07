class Cylinder
{
    public double height;
    public Circle circle;

    public Cylinder(double h, Circle c)
    {
        height = h;
        circle = c;
    }

    public double GetVolume()
    {
        double volume = circle.GetArea() * height;
        return volume;
    }


}