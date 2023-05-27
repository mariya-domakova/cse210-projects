using System;

public class SerializableScripture
{
    public string _text;
    public string _book;
    public int _chapter;
    public int _verse;
    public int _endVerse;

    public Scripture GetScripture()
    {
        return new Scripture(_text, new Reference(_book, _chapter, _verse, _endVerse));
    }
}