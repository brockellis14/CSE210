using System;
using System.Collections.Generic;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected int _totalPoints;
    protected bool _isComplete;
    private static List<Goal> _goals = new List<Goal>();

    // Constructor to initialize goal attributes
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _totalPoints = 0; // Initialize points to 0
        _isComplete = false; // Goal starts incomplete
        _goals.Add(this); // Add this goal to the goal bank
    }

    // Abstract methods to be overridden by derived classes
    public abstract void SetGoal(string name, string description, int points);
    public abstract void CompleteGoal();
    public abstract string DisplayGoal();

    // Method to display total points
    public string DisplayTotalPoints()
    {
        return "Total Points for " + _name + ": " + _totalPoints;
    }

    // Static method to display all goals in the bank
    public static string DisplayGoals()
    {
        string goalDetails = "Goals in your goal bank:\n";

        foreach (var goal in _goals)
        {
            goalDetails += goal.DisplayGoal() + "\n";
        }

        return goalDetails;
    }

    // Helper method to update the goal in the goal list
    protected void UpdateGoalList()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            if (_goals[i] == this)
            {
                _goals[i] = this; // Update the goal
                break;
            }
        }
    }

    // Add points to total
    protected void AddPoints(int points)
    {
        _totalPoints += points;
    }
}
