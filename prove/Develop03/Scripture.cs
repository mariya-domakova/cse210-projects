using System;

public class Scripture
{
    private Word[] _words;
    private List<int> _visibleWordsIndexes;
    private Reference _reference;

    // This constructor takes a text string and a reference object, splits the text 
    // into words and creates Word objects from them, and assigns them to the _words array. 
    // It initializes the _visibleWordsIndexes list with all the indexes of the words. 
    // Finally, it assigns the reference object to the _reference variable.
    public Scripture(string text, Reference reference)
    {
        string[] wordStrings = text.Split(' ');
        _words = new Word[wordStrings.Length];

        for (int i = 0; i < wordStrings.Length; i++)
        {
            _words[i] = new Word(wordStrings[i]);
        }
        
        _reference = reference;
        _visibleWordsIndexes = Enumerable.Range(0, _words.Length).ToList();
    }

    public void HideWords(int amount)
    {
        Random random = new Random(); 
        for (int i = 0; i < amount; i++) 
            {
                if (_visibleWordsIndexes.Count == 0)
                    return;
                
                var visibleWordsIndex = random.Next(0, _visibleWordsIndexes.Count);
                var wordsIndex = _visibleWordsIndexes[visibleWordsIndex];
                _visibleWordsIndexes.RemoveAt(visibleWordsIndex);
                _words[wordsIndex].Hide();
            }
    }

    public override string ToString()
    {
        return _reference.ToString() + " " + string.Join<Word>(' ', _words);
    }

    internal bool HasMoreWords()
    {
        return _visibleWordsIndexes.Count > 0;
    }
}