using System;
using System.IO; 

public static class Journal 
{
    public static List<Entry> _entries = new List<Entry>(); 

    public static void Add(string prompt, string response)
    {
        _entries.Add(new Entry(prompt, response));
    }

    public static void Save(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.Write(Newtonsoft.Json.JsonConvert.SerializeObject(_entries));
        }
    }

    public static void Load(string fileName)
    {
        var lines = System.IO.File.ReadAllText(fileName);
        _entries = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Entry>>(lines);
    }

    public static string GetEntries()
    {
        return string.Join("\n\n", _entries);
    }
}