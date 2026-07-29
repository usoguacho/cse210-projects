public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is something I learned today?",
        "What am I grateful for today?"
    };

    private Random _random = new Random();

    // Prompts the user with a random prompt, records their response as a new Entry
    public void Write()
    {
        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        Console.Write("> ");
        string? response = Console.ReadLine();

        string date = DateTime.Now.ToShortDateString();

        Entry entry = new Entry(date, prompt, response ?? "");
        _entries.Add(entry);
    }

    // Displays every entry currently in the journal
    public void Display()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("The journal is empty.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.GetDisplayText());
        }
    }

    // Saves the current journal to a file, one entry per line
    public void SaveToFile(string filename)
    {
        using StreamWriter writer = new StreamWriter(filename);
        foreach (Entry entry in _entries)
        {
            writer.WriteLine(entry.GetFileLine());
        }

        Console.WriteLine($"Journal saved to {filename}.");
    }

    // Loads a journal from a file, replacing any entries currently in memory
    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine($"Could not find a file named {filename}.");
            return;
        }

        List<Entry> loadedEntries = new List<Entry>();
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            if (!string.IsNullOrWhiteSpace(line))
            {
                loadedEntries.Add(Entry.FromFileLine(line));
            }
        }

        _entries = loadedEntries;
        Console.WriteLine($"Journal loaded from {filename}.");
    }
}