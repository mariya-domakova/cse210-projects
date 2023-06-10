using System;

public class ReflectingActivity : Activity
{
    private string[][] _prompts = new string[][]
    {
        new string[]
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        },
        new string[]
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        }
    };

    public ReflectingActivity()
    {
        SetName("Reflecting Activity");
    }
    
    protected override string _activityDescription => "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

    protected override void ActivityContent()
    {
        Console.WriteLine("\nConsider the following prompt:");
        string[] promptSet1 = _prompts[0];
        string randomPrompt1 = GetRandomPrompt(promptSet1);
        Console.WriteLine($"\n--- {randomPrompt1} ---");

        Console.WriteLine("\nWhen you have something in mind, press Enter to continue.");
        Console.ReadLine();
        
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ConsoleAnimationUtility.Countdown(5);
        Console.Clear();
        string[] promptSet2 = _prompts[1];

        int time = 0;
        while (time < GetDuration())
        {
            string randomPrompt2 = GetRandomPrompt(promptSet2);
            Console.Write($"\n> {randomPrompt2} ");
            ConsoleAnimationUtility.Spinner(10);
            time += 10;
        }
        Console.WriteLine();
    }

    private string GetRandomPrompt(string[] promptSet)
    {
        return promptSet[new Random().Next(0, promptSet.Length)];
    }
}