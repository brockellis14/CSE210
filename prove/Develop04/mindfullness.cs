public class MindfulnessActivity
{
    // Protected variables to store the activity's duration and description
    private int duration;
    private string description;

    // Public getter and setter for duration and description
    public int Duration
    {
        get { return duration; }
        set { duration = value; }
    }

    public string Description
    {
        get { return description; }
        set { description = value; }
    }

    // Virtual method to be overridden by subclasses
    public virtual void PerformActivity()
    {
        Console.WriteLine("Performing a mindfulness activity...");
    }
}
