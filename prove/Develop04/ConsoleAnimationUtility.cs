using System;

public static class ConsoleAnimationUtility
{
    static char[] _spinnerChars = new char[]{'/', '—', '\\', '|'};

    public static void Spinner(int time)
    {
        for (int i = 0; i < time * 4; i++)
        {
            Console.Write(_spinnerChars[i % _spinnerChars.Length]);
            Thread.Sleep(250);
            Console.Write("\b");
        }
        Console.Write(" \b");
    }

    public static void Countdown(int time)
    {
        for (int i = time; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b");
        }
        Console.Write(" \b");
    }
}