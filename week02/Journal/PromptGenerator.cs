using System;
using System.Collections.Generic;
public class PromptGenerator
{
    public List<string> _prompts;

    public string GeneratePrompt()
    {   
        // Initialize prompts
        _prompts = new List<string>();
        _prompts.Add("What was the best part of your day?");
        _prompts.Add("Write something funny that happened today.");
        _prompts.Add("What did you learn today?");
        _prompts.Add("What could've you done better today?");
        _prompts.Add("What made you happy today?");
        _prompts.Add("Did you felt sad today? What could you learn from it?");
        _prompts.Add("Who was the most interesting person you interacted with today?");
        _prompts.Add("What was the strongest emotion you felt today?");
        _prompts.Add("If you had one thing you could do over today, what would it be?");
        _prompts.Add("What are you grateful for today?");
        _prompts.Add("What challenge did you face today and how did you handle it?");
        _prompts.Add("What goal did you work towards today?");

        // Get random prompt
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}