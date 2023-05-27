using System;
using Newtonsoft.Json;

public class ScriptureMemorizer
{
    private List<SerializableScripture> _scriptures;
    private Scripture _currentScripture;

    public void ReadFromFile(string filename)
    {
        string json = File.ReadAllText(filename);
        _scriptures = JsonConvert.DeserializeObject<List<SerializableScripture>>(json);
    }

    public void GetRandomScripture()
    {
        Random random = new Random();
        int index = random.Next(_scriptures.Count);
        _currentScripture = _scriptures[index].GetScripture();
    }

    public void PrintMenu()
    {
        Console.Clear();
        Console.WriteLine(_currentScripture.ToString());

        Console.Write("\nPress Enter to continue or type 'quit' to finish: ");

        var input = Console.ReadLine();
        if (input.ToLower().Contains("quit") || !_currentScripture.HasMoreWords())
            return;
        _currentScripture.HideWords(3); // Here you can change the number of words to hide.
        PrintMenu();
    }
}