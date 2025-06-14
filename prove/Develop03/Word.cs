public class Word
{
    public string Text { get; set; }
    public int Length { get; set; }
    public bool Hidden { get; set; } = false;

    public Word(string text)
    {
        Text = text;
        Length = text.Length;
    }

    public void Hide()
    {
        Hidden = true;
    }
}