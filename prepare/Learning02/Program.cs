using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Data Scientist";
        job1._company = "Microsoft";
        job1._startYear = 2017;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Database Administrator";
        job2._company = "KeyBank";
        job2._startYear = 2021;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Brock Ellis";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}