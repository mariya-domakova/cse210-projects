using System;

public class Entry
{
    public string _prompt;
    public string _response;
    public DateTime _date;
    public Entry(string prompt, string response)
    {
        _prompt = prompt;
        _response = response;
        _date = DateTime.Now;
    }
    
    public override string ToString() => $"Date: {_date.ToShortDateString()} - Prompt: {_prompt}\nResponse: {_response}";
}