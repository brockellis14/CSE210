using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job("Private Banker", "KeyBank", 2022, 2024);
        // job1.DisplayJob();
        Job job2 = new Job("CEO", "Microsoft", 2020, 2022);
        // job2.DisplayJob();
        Resume myResume = new Resume("Brock Ellis");
        myResume.AddJob(job1);
        myResume.AddJob(job2);
        myResume.DisplayResume();
    }

    Abstraction is the process of hiding complex implementation details while exposing only the necessary functionalities to users. It simplifies code writing by allowing developers to interact with essential aspects of an object without needing to understand its internal workings. This helps in managing complexity and making software more maintainable.

As mentioned earlier, a major benefit of abstraction is simplification for the user, which leads to faster and more efficient code writing. By providing a clear interface and hiding unnecessary details, developers can focus on high-level functionality without worrying about intricate implementations.

One practical application of abstraction is simplifying mathematical and scientific calculations for common tasks, such as finding the area of a pyramid, calculating the length of a vector, or determining the probability of an event. This is similar to writing functions in Python, but with abstraction, you can encapsulate multiple related methods within a class. This makes it easier for users to perform complex calculations with just a few calls to the class and its methods.
}