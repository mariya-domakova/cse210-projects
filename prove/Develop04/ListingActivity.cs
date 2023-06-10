using System;

public class ListingActivity : Activity
{
    private string[] _prompts = new string[]
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private static List<string> _userInputs = new List<string>();
    
    public ListingActivity()
    {
        SetName("Listing Activity");
    }
    
    protected override string _activityDescription => "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

    protected override void ActivityContent()
    {
        Console.WriteLine("\nList as many responses you can to the following prompt:");
        string[] prompts = _prompts;
        string randomPrompt = GetRandomPrompt(prompts);
        Console.WriteLine($"--- {randomPrompt} ---");
        
        Console.Write("You may begin in: ");
        ConsoleAnimationUtility.Countdown(5);
        Console.WriteLine();

        int time = 0;
        DateTime startTime = DateTime.Now;
        while (time < GetDuration())
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            _userInputs.Add(response);
            time = (int)(DateTime.Now - startTime).TotalSeconds;
        }
        Console.WriteLine($"You listed {_userInputs.Count} items!");
        Console.WriteLine();
    }

    private string GetRandomPrompt(string[] promptSet)
    {
        return promptSet[new Random().Next(0, promptSet.Length)];
    }
}