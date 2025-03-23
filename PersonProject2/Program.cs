class Program
{
    public static void Main(String[] args)
    {
        // Console.WriteLine("Hello World")
        Person myPerson = new Person("Bob", "Bubba", 97);
        Console.WriteLine($"{myPerson.DisplayPerson()}");
        
        PoliceMan myPoliceMan = new PoliceMan("Taser", "Joe", "Mama", 32);
        Console.WriteLine($"{myPoliceMan.DisplayPoliceMan()}");

        Doctor myDoctor = new Doctor("Bob", "Bubba", 97);
        Console.WriteLine($"{myDoctor.DisplayDoctor()}");

    }
}