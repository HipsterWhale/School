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
            Console.WriteLine("Cannot add a null entry.");
        }
    }


    public void DisplayJournal()
    {
        if (_entries == null || _entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
            return;
        }

        foreach (var entry in _entries)
        {
            entry.DisplayEntry();
            Console.WriteLine();
        }
    }
    
}