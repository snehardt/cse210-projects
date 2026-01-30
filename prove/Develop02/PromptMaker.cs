using System;
using System.Collections.Generic;

public class PromptMaker
{
    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was your overall mood today? Why?"
    };
    public Random _rand = new Random();
 
    public string GetPrompt()
    {
        int x = _rand.Next(_prompts.Count);
        return _prompts[x];
    }
}
    
    