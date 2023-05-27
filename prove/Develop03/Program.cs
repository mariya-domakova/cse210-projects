using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureMemorizer memorizer = new ScriptureMemorizer();
        memorizer.ReadFromFile("scriptures.json");

        memorizer.GetRandomScripture();
        memorizer.PrintMenu();
    }
}

// Exceeding Requirements:
// I created a json file that contains some scriptures. To show a random scripture from this file, 
// I implemented a class called ScriptureMemorizer. I additionally included SerializableScripture class to 
// be able to store the Scripture objects in a json file and read them back into the program.