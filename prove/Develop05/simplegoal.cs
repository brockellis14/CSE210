public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points) { }

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
        if (!_isComplete)
        {
            _isComplete = true;
            AddPoints(_points); // Add points when completed
            UpdateGoalList();
        }
    }

    // Override DisplayGoal method
    public override string DisplayGoal()
    {
        return "Simple Goal: " + _name + ", " + _description + ", Points: " + _points + ", Completed: " + _isComplete;
    }
}