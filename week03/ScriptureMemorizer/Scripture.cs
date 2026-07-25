public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        // Split the scripture text into individual words
        _words = new List<Word>();
        string[] splitWords = text.Split(' ');
        foreach (string word in splitWords)
        {
            _words.Add(new Word(word));
        }
    }

    // Hides a given number of randomly chosen words.
    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            int index = _random.Next(_words.Count);
            _words[index].Hide();
        }
    }

    // True once every word in the scripture is hidden
    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    // Returns the reference plus the full scripture text, with hidden words shown as underscores
    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();
        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }

        return _reference.GetDisplayText() + "\n" + string.Join(" ", displayWords);
    }
}