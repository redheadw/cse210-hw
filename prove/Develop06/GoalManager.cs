using System;
using System.Collections.Generic;
using System.IO;


//Goal manager
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private const string GoalsFile = "C:/Users/thort/Downloads/cse 210/cse210-hw/prove/Develop06/goals.txt";
    private int _score;
    public void Start()
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\n--- Goal Tracking Menu ----");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record Goal Progress");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");
            Console.WriteLine("Select an options: ");

            string choice = Console.ReadLine();
            switch(choice)
            {
                case"1":
                    CreatGoal();
                    break;
                case"2":
                    RecordEvent();
                    break;
                case"3":
                    ListGoalDetails();
                    break;
                case"4":
                    DisplayPlayerInfo();
                    break;
                case"5":
                    SaveGoal();
                    break;
                case"6":
                    LoadGoals();
                    break;
                case"7":
                exit = true;
                Console.WriteLine("Goodbye");
                break;
            }
        }
    }
    public void SaveGoal()
    {
        using (StreamWriter write = new StreamWriter(GoalsFile))
        {
            write.WriteLine(_score);
            foreach (var goal in _goals)
            {
                write.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved to goal.txt");
    }
    public void LoadGoals()
    {
        if (File.Exists(GoalsFile))
        {
            using (StreamReader reader = new StreamReader(GoalsFile))
            {
                if (int.TryParse(reader.ReadLine(), out int loadedScore))
                {
                    _score = loadedScore;
                }
                _goals.Clear();
                
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(", ");
                    string type = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);

                    Goal goal;
                    if (type == "SimpleGoal")
                    {
                        bool isComplete = bool.Parse(parts[4]);
                        goal = new SimpleGoal(name, description, points);
                    }
                    else if (type == "EternalGoal")
                    {
                        goal = new EternalGoal(name, description, points);
                    }
                    else if (type == "Checklist Goal")
                    {
                        int completeCount = int.Parse(parts[4]);
                        int targetCount = int.Parse(parts[5]);
                        int bonus = int.Parse(parts[6]);
                        goal = new ChecklistGoal(name, description, points, targetCount, bonus);
                        for (int i = 0; i < completeCount; i++)
                        {
                            goal.RecordEvent();
                        }
                    }
                    else
                    {
                        continue;
                    }
                    _goals.Add(goal);
                }

                
            }
            Console.WriteLine("Goals Loaded");
            _score = CalculateTotalScore();
            
        }
        else
        {
            Console.WriteLine("No saved goals found");
        }
        
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nCurrent Score: {_score}");
    }
      
    private void CreatGoal()
    {
        Console.WriteLine("\nSelect Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choose an option: ");

        string goalType = Console.ReadLine();
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points for this goal: ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        switch (goalType)
        {
            case "1":
                newGoal = new SimpleGoal(name, description, points);
                break;
            case "2":
                newGoal = new EternalGoal(name, description, points);
                break;
            case "3":
                Console.Write("Enter target times to complete: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points on completion: ");
                int bonus = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(name, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid goal type. Goal not created");
                return;
        }
        _goals.Add(newGoal);
        Console.WriteLine("Goal created");
    }
    private void RecordEvent()
    {
        Console.WriteLine("\nSelect a Goal to Record Progress:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
            
        }
        Console.WriteLine("Enter the number of the goal you want to record: ");
        if (int.TryParse(Console.ReadLine(), out int goalIndex) && goalIndex > 0 && goalIndex <= _goals.Count)
        {
            Goal selectedGoal = _goals[goalIndex - 1];
            int pointsEarned = selectedGoal.RecordEvent();
            _score += pointsEarned;

            Console.WriteLine($"Total Score: {_score}");
        }   
            else
            {
                Console.WriteLine("Invalid goal selection.");
            }
            
    }
    
    private void ListGoalDetails()
    {
        Console.WriteLine("\n   Goals  ");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }
    public int CalculateTotalScore()
    {
        int totalScore = 0;
        foreach (var goal in _goals)
        {
            if (goal.IsComplete)
            {
                totalScore += goal.CalculatePoints();
            }
        }
        return totalScore;
        
    }
}