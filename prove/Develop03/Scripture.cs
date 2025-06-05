public class Scripture
{
    private List<Word> _words;
    private bool _hidden;


    public Scripture(string text)
    {
        _words = new List<Word>();
        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
        _hidden = false;
    }
    public void Print()
    {
        foreach (Word word in _words)
        {
            if (word.Hidden)
            {
                Console.Write("_".PadRight(word.Length) + " ");
            }
            else
            {
                Console.Write(word.Text + " ");
            }
        }
        Console.WriteLine();
    }

    public void Hide_words(int numberOf_words)
    {
        
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