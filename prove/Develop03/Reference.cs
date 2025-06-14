
public class Reference
{
    private string book { get; set; }
    private int chapter { get; set; }
    private int startVerse { get; set; }
    private int endVerse { get; set; }

    public Reference(string reference)
    {
        string[] parts = reference.Split(' ');
        book = parts[0];
        parts = parts[1].Split(':');
        chapter = int.Parse(parts[0]);

            string[] verseParts = parts[1].Split('-');
            startVerse = int.Parse(verseParts[0]);
            if (verseParts.Length > 1)
            {
                endVerse = int.Parse(verseParts[1]);
            }
            else
            {
                endVerse = startVerse;
            }
    }
    
    public void Print()
    {
        Console.Write($"{book} {chapter}:{startVerse}");
        if (endVerse > startVerse)
        {
            Console.Write($"-{endVerse}");
        }
    }
    
}