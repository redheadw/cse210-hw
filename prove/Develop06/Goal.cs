using System;

// base goal class(inheritance)
public abstract class Goal
{
    protected string _shortname;
    protected string _description;
    protected int _points;
    public string Name { get; }
    public int Points { get;  }
    public abstract bool IsComplete { get; }
    public abstract bool IsGoalComplete();

    public Goal(string name, string description, int points)
    {
        _shortname = name;
        _description = description;
        _points = points;
    }
    
  
    public abstract int CalculatePoints();   
    public abstract int RecordEvent();
    public abstract string GetStringRepresentation();   
    
    public virtual string GetDetailsString()
    
    {
        return $"[ ] {_shortname}: {_description}";
    }
  
}