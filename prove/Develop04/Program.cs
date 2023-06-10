using System;

class Program
{
    static void Main(string[] args)
    {
        var menu = new Menu(new BreathingActivity(), new ReflectingActivity(), new ListingActivity());
        menu.PrintMenu();
    }
}

// Exceeding Requirements:
// In order to avoid the overuse of getters and setters and promote the principle of encapsulation, 
// I learned how to use properties and implemented them in both the base class and the derived classes. 
// Also, I made a separate animation utility to improve code organization and structure.