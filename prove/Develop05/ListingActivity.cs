using System;
using System.Collections.Generic;
using System.Timers;
// ListingActivity
public class ListingActivity : MindfulnessActivity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people you appreciate?",
        "What are your strengths?",
        "Who helped you this week?",
        "What are things you are pround of?",
        "Whar are attrabutes you like in people?"
    };
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good thing in your life by having you list as many things as you can.")
    {

    }
    public override void PerformActivity()
    {
        StartActivity();

        List<string> tempPrompts = new List<string>(_prompts);

        Random random = new Random();
        string prompt = tempPrompts[random.Next(tempPrompts.Count)];
        Console.WriteLine(prompt);
        tempPrompts.Remove(prompt);
        ShowPauseAnimation(3);

        List<string> responses = new List<string>();
        int elapsed = 0;
        while (elapsed < _duration)

        {
            Console.Write("Enter a response: ");
            string response = Console.ReadLine();
            responses.Add(response);
            elapsed += 3;
        }
        Console.WriteLine($"You listed {responses.Count} items.");
        EndActivity();
    }
        
}