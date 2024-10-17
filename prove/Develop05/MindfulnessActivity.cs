using System;
using System.Security.Cryptography.X509Certificates;
// Mindfulness Activity
public class MindfulnessActivity
{   private string _activityName;
    private string _description;
    protected int _duration;

    public MindfulnessActivity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public void StartActivity()
    {
        Console.WriteLine($"Starting {_activityName}");
        Console.WriteLine(_description);
        Console.WriteLine("How many seconds would you like to do this activity (in seconds): ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowPauseAnimation(3);
    }
    public void EndActivity()
    {
        Console.WriteLine("Great job! Completing an activity.");
        Console.WriteLine($"You completed: {_activityName} for {_duration} seconds.");
        ShowPauseAnimation(3);
    }
    protected void ShowPauseAnimation(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.WriteLine($".");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
    public virtual void PerformActivity()
    {
        Console.WriteLine("Performing a generic mindfulness activity...");
    }
    
    
}