using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Menu menu = new Menu();
        menu.PrintMenu();
    }
}

// Exceeding Requirements:
// I downloaded JSON library and used it in a Journal class (Journal.cs).
// Using this library simplified my code, otherwise I would need to write 
// my own code to handle the conversion of some objects.   