using System;
//Checklist class
public class ChecklistGoal : Goal 
{
    private int _targetCount;
    private int _completeCount;
    private int _bonus;
    public ChecklistGoal(string name, string description, int  points, int target, int bonus) : base(name, description, points)
    {
        _targetCount = target;
        _completeCount = 0;
        _bonus = bonus;
    }
    public override int CalculatePoints()
    {
        return _completeCount >= _targetCount ? Points + _bonus : Points;
    }
    public override int RecordEvent()
    {
       if (_completeCount < _targetCount)
       {
            _completeCount++;
            if (_completeCount == _targetCount)
            {
                return _points + _bonus;
            }
            return _points;
       }
       return 0;

    }
    public override bool IsComplete => _completeCount >= _targetCount;

    public override bool IsGoalComplete() => IsComplete;
        public override string GetStringRepresentation()
    {
        return $"ChecklistGoal, {_shortname}: {_description},{_points},{_completeCount},{_targetCount},{_bonus}";
    }
}