class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }
    public void Display()
    {
        Console.Clear();
        Console.WriteLine(_reference.GetReference());
        Console.WriteLine();

        foreach (Word word in _words)
        {
            Console.Write(word.GetDisplayText() + ' ');
        }
        Console.WriteLine();
    }
    public void HideWords(int count)
    {
        int hidden = 0;
        while (hidden < count)
        {
            int index = _random.Next(_words.Count);
            if (!_words[index].Hidden())
            {
                _words[index].Hide();
                hidden++;
            }
            if (AllHidden())
                break;
        }
    }
    public bool AllHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.Hidden())
                return false;
        }
        return true;
    }
}