using System;

public class Menu 
{
    public void PrintMenu()
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Quit");
        
        Console.Write("What would you like to do? ");
        int option = int.Parse(Console.ReadLine());
        string fileName;
        switch (option)
        {
            case 1:
                Write();
                break;
            case 2:
                Console.WriteLine("Here we go");
                Console.WriteLine(Journal.GetEntries());
                PrintMenu();
                break;
            case 3:
                Console.WriteLine("Enter the file name to save to.");
                fileName = Console.ReadLine();
                Journal.Save(fileName);
                break;
            case 4:
                Console.WriteLine("Enter the file name to load from.");
                fileName = Console.ReadLine();
                Journal.Load(fileName);
                PrintMenu();
                break;
            case 5:
                return;
            default:
                Console.WriteLine($"Invalid option {option}.");
                PrintMenu();
                break;
        }
    }

    public void Write() {
        var prompt = PromptGenerator.GetPrompt();
        Console.WriteLine(prompt);
        var response = Console.ReadLine();
        Journal.Add(prompt, response);
        PrintMenu();
    }
    
}