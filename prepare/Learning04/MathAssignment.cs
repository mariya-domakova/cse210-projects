using System;

public class MathAssignment : Assignment
{
    private string _texbookSection;
    private string _problems;

    public MathAssignment(string name, string topic, string section, string problems) : base(name, topic)
    {
        _texbookSection = section;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_texbookSection} Problems {_problems}";
    }
}