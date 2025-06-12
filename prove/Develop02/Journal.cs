class Journal
{
    private List<Entry> _entries;
    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        if (entry != null)
        {
            _entries.Add(entry);
        }
        else
        {
            Program.TypeLine("Cannot add a null entry.");
        }
    }

    public void SaveToFile(string filename)
    {
        if (string.IsNullOrWhiteSpace(filename))
        {
            throw new ArgumentException("Filename cannot be null or empty.", nameof(filename));
        }

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry.GetDate().ToShortDateString()}|{entry.GetPrompt()}|{entry.GetResponse()}");
            }
        }
    }
    public void DisplayJournal()
    {
        if (_entries == null || _entries.Count == 0)
        {
            Program.TypeLine("No entries found.");
            return;
        }

        foreach (var entry in _entries)
        {
            entry.DisplayEntry();
            Program.TypeLine();
        }
    }
    
}