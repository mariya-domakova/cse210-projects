using System;

class Program
{
    static void Main(string[] args)
    {
        var menu = new Menu(new BreathingActivity(), new ReflectingActivity(), new ListingActivity());
        menu.PrintMenu();
    }
}