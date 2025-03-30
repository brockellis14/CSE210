public class CheckListGoal : Goal
{
    private int _timesCompleted;
    private int _targetTimes;
    private int _bonusPoints;

    public CheckListGoal(string name, string description, int points, int targetTimes, int bonusPoints) : base(name, description, points)
    {
        _timesCompleted = 0;
        _targetTimes = targetTimes;
        _bonusPoints = bonusPoints;
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
        if (_timesCompleted >= _targetTimes)
        {
            AddPoints(_bonusPoints); // Add bonus points if target is met
        }
        AddPoints(_points); // Add regular points
        UpdateGoalList();
    }

    // Override DisplayGoal method
    public override string DisplayGoal()
    {
        return "CheckList Goal: " + _name + ", " + _description + ", Points per Completion: " + _points + 
               ", Target Times: " + _targetTimes + ", Times Completed: " + _timesCompleted + ", Bonus Points: " + _bonusPoints;
    }
}
