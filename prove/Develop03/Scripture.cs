public class Scipture
{
    private List<Word> words;


    public Scipture(string text)
    {
        words = new List<Word>();
        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            words.Add(new Word(word));
        }
    }
    public void Print()
    {
        foreach (Word word in words)
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

    public void HideWords(int numberOfWords)
    {
        Random random = new Random();
        int count = 0;
        while (count < numberOfWords)
        {
            int index = random.Next(words.Count);
            if (!words[index].Hidden)
            {
                words[index].Hidden = true;
                count++;
            }
        }
    }
}