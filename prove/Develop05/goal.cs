using System;
using System.Collections.Generic;

public class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private int _totalPoints;
    private static List<Goal> _goals = new List<Goal>(); // Static list to hold all goals in the bank
    private bool _isComplete;

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

    // Set goal attributes
    public void SetGoal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    // Mark goal as complete and add points
    public void CompleteGoal()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            AddPoints(_points);
            UpdateGoalList();
        }
    }

    // Display goal details
    public string DisplayGoal()
    {
        return "Goal: " + _name + ", Description: " + _description + ", Points: " + _points + ", Total Points: " + _totalPoints + ", Completed: " + _isComplete;
    }

    // Add points to total
    protected void AddPoints(int points)
    {
        _totalPoints += points;
    }

    // Deduct points from total
    protected void DeductPoints(int points)
    {
        _totalPoints -= points;
    }

    // Display total points for this goal
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
    private void UpdateGoalList()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            if (_goals[i] == this)
            {
                _goals[i] = this; // Update the goal (although the goal instance itself is already modified)
                break;
            }
        }
    }
}
