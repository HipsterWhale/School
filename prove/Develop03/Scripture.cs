public class Scripture
{
    private List<Word> _words;
    private Reference _reference;

    public Scripture(string Reference, string text)
    {

        _reference = new Reference(Reference);

        _words = new List<Word>();
        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }
    public void Print()
    {

        _reference.Print();
        Console.Write(" ");

        foreach (Word word in _words)
        {
            if (word.Hidden)
            {
                foreach (char c in word.Text)
                {
                    Console.Write("_");
                }
                Console.Write(" ");
            }
            else
            {
                Console.Write(word.Text + " ");
            }
        }
        Console.WriteLine();
    }

    public bool Hide_words(int numberOf_words)
    {
        Random rand = new Random();
        int hiddenCount = 0;
        List<int> availableIndexes = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].Hidden)
            {
                availableIndexes.Add(i);
            }
        }

        while (hiddenCount < numberOf_words && availableIndexes.Count > 0)
        {
            int idx = rand.Next(availableIndexes.Count);
            _words[availableIndexes[idx]].Hide();
            availableIndexes.RemoveAt(idx);
            hiddenCount++;
        }

        return AllWordsHidden();
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.Hidden)
            {
                return false;
            }
        }
        return true;
    }
}