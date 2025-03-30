public class EternalGoal : Goal
{
    private int _timesCompleted;

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        _timesCompleted = 0;
    }

    // Override SetGoal method
    public override void SetGoal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    // Override CompleteGoal method
    public override void CompleteGoal()
    {
        _timesCompleted++;
        AddPoints(_points); // Add points for each completion
        UpdateGoalList();
    }

    // Override DisplayGoal method
    public override string DisplayGoal()
    {
        return "Eternal Goal: " + _name + ", " + _description + ", Points per Completion: " + _points + ", Times Completed: " + _timesCompleted;
    }
}
