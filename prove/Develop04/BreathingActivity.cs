using System;

public class BreathingActivity : Activity
{
    private int[] _breathingTimes = new int[] {2, 3, 4, 6, 4, 6};
    
    public BreathingActivity()
    {
        SetName("Breathing Activity");
    }

    protected override string _activityDescription => "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";

    protected override void ActivityContent()
    {
        int time = 0;
        int i = 0;
        while (time < GetDuration())
        {
            Console.Write("\nBreathe in...");
            time += _breathingTimes[i % _breathingTimes.Length];
            ConsoleAnimationUtility.Countdown(_breathingTimes[i++ % _breathingTimes.Length]);
            Console.Write("\nBreathe out...");
            time += _breathingTimes[i % _breathingTimes.Length];
            ConsoleAnimationUtility.Countdown(_breathingTimes[i++ % _breathingTimes.Length]);
            Console.WriteLine();
        }
    }
}