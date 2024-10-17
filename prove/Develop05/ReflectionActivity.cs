using System;
using System.Collections.Generic;
using Microsoft.Win32.SafeHandles;
// ReflectionActivity.cs
public class ReflectionActivity : MindfulnessActivity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you did something good.",
        "Think of a time when you help lift someone else.",
        "Think of a time you did something hard.",
        "Think of a time you felt joy.",
        "Think of a time you served others.",
        "Think of a time you saw God in your life.",
    };
    private List<string> _questions = new List<string>
    {
        "Why did this experiencce matter to you?",
        "How did you feel when it was over?",
        "What did you learn from the experience?",
        "How can you have more positive experiences?",
    };
    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown personal integrity and resilience.")
    {

    }
    public override void PerformActivity()
    {
        StartActivity();

        List<string> tempPrompts = new List<string>(_prompts);
        List<string> tempQuestions = new List<string>(_questions);

        Random random = new Random();
        while (tempPrompts.Count > 0)
        {
            string prompt = tempPrompts[random.Next(tempPrompts.Count)];
            Console.WriteLine(prompt);
            tempPrompts.Remove(prompt);
            ShowPauseAnimation(3);

            int elapsed = 0;
            while (elapsed < _duration && tempQuestions.Count > 0)
            {
                string question = tempQuestions[random.Next(tempQuestions.Count)];
                Console.WriteLine(question);
                tempQuestions.Remove(question);
                ShowPauseAnimation(3);
                elapsed += 3;
            }
        }
        
        
        EndActivity();
    }
}