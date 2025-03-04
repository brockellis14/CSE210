using System;


public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>(); // Creates a list of jobs for one _name
    public void Display()
    {
        Console.WriteLine($"Resume of {_name}:");
        
        foreach (Job job in _jobs)  // Loop through each job and display it
        {
            job.Display();
        }
    }
}
