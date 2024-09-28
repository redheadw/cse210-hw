using System;
using System.Collections.Generic;
using System.IO;
public class PromptGenerator
{
    private List<string> _prompt;
    public PromptGenerator()
    {
        _prompt = new List<string>()
        {
            "Todays Gratitude List",
            "The Little Things",
            "Things I want my children to know.",
            "Count you many blessings",
            "What made today interesting"
        };
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompt.Count);
        return _prompt[index];
    }
}