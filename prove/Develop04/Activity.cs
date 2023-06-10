using System;
 
public abstract class Activity
{
    private string _activityName;
    protected abstract string _activityDescription { get; }
    private int _duration;

    public string GetName()
    {
        return _activityName;
    }
    
    protected void SetName(string name)
    {
        _activityName = name;
    }

    protected int GetDuration()
    {
        return _duration;
    }

    protected void SetDuration(int duration)
    {
        _duration = duration;
    }

    protected virtual string _startingMessage => $"Welcome to the {GetName()}";
    protected virtual string _endingMessage => $"Well done!\n\nYou have completed another {GetDuration()} seconds of the {GetName()}.";

    public void ShowActivity()
    {
        Console.WriteLine(_startingMessage);
        Console.WriteLine();
        Console.WriteLine(_activityDescription);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        SetDuration(int.Parse(Console.ReadLine()));
        Console.Clear();

        Console.WriteLine("Get ready...");
        ConsoleAnimationUtility.Spinner(5);
        ActivityContent();
        Console.WriteLine();
        
        Console.WriteLine(_endingMessage);
        ConsoleAnimationUtility.Spinner(3);
        Console.Clear();
    }

    // This method is defined in derived classes.
    protected abstract void ActivityContent();
}