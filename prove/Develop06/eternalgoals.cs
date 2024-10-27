using System;
//Eternal goals
public class EternalGoal : Goal 
{
    public EternalGoal(string name, string description, int points) : base (name, description, points) {}
    public override int CalculatePoints()
    {
        return Points;
    }
    public override int RecordEvent()
    {
    
       return _points;
    }
    public override bool IsComplete => true;
    public override bool IsGoalComplete() => IsComplete;
   
    public override string GetStringRepresentation()
    {
        return $"EternalGoal, {_shortname},{_description},{_points}";
    }
}