using System;
//BreathingActivity.cs
public class BreathinActivity : MindfulnessActivity
{
    public BreathinActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. CLear your mind and focus on your breathing.")
    {

    }    
    public override void PerformActivity()
    {
        StartActivity();
        
        for (int i = 0; i < _duration; i += 5)
        {
            Console.WriteLine("Breath in ...");
            ShowPauseAnimation(3);
            Console.WriteLine("Breathe out...");
            ShowPauseAnimation(3);
        }
        EndActivity();
    }
}    