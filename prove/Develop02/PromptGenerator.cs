using System;

public static class PromptGenerator
{
    static Random random = new Random();

    public static string[] _prompts = new string[]
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What are you grateful for today?",
        "How can I be a better person tomorrow?",
        "What is one negative thing I experienced today?",
        "What did I learn today?"
    };

    public static string GetPrompt()
    {
        int index = random.Next(_prompts.Length);
        return _prompts[index];
    }
}