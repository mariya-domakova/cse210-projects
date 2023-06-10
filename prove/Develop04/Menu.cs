using System;

public class Menu
{
    private Activity[] _activities;

    public Menu(params Activity[] activities)
    {
        _activities = activities;
    }

    public void PrintMenu()
    {
        Console.WriteLine("Menu Options:");
        for (int i = 0; i < _activities.Length; i++)
        {
            Console.WriteLine($"{i + 1}. Start {_activities[i].GetName().ToLower()}");
        }
        Console.WriteLine($"{_activities.Length + 1}. Quit");
        Console.Write("Select choice from the menu: ");
        int option = int.Parse(Console.ReadLine());
        Console.Clear();
        if (option > 0 && option <= _activities.Length + 1) 
        {
            if (option == _activities.Length + 1)
                return;
            
            _activities[option - 1].ShowActivity();
        }
        else
        {
            Console.WriteLine($"Invalid option {option}.");
            ConsoleAnimationUtility.Spinner(3);
        }
        PrintMenu();
    }
}