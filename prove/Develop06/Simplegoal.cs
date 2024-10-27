using System;

//Simple goal
public class SimpleGoal : Goal
{
    private bool _isComplete; 
    public SimpleGoal(string name, string description, int points) : base (name, description, points)
    {
        _isComplete = false;
    }
    public override int CalculatePoints()
    {
        return _isComplete ? Points : 0;
    }
    public override string GetDetailsString()
    {
        return $"{Name} | Points: {Points} | Completed1 {_isComplete}";
    }
    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return CalculatePoints();
        }
        return 0;
    }
    public override bool IsComplete => _isComplete;
    public override bool IsGoalComplete() => IsComplete;
    
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal, {_shortname},{_description},{_points},{_isComplete}";
    }
    
}