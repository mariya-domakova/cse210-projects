using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public void Hide()
    {
        _isHidden = true;
    }

    public Word(string word)
    {
        _text = word;
    }

    public override string ToString() 
    {
        if (_isHidden) 
            return new String('_', _text.Length);
        else
            return _text;
    }
}
