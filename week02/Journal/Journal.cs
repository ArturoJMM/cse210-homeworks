public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public string file = "Journal.txt";

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    
    public void SaveToFile(string fileName)
    {
        List<string> lines = new List<string>();
        foreach (Entry entry in _entries)
        {
            lines.Add(entry._date.ToString());
            lines.Add(entry._promptText);
            lines.Add(entry._entryText);
            lines.Add("---");
        }

        File.WriteAllLines(fileName + ".txt", lines);

    }

    public void LoadFormFile(string fileName)
    {
        if (File.Exists(fileName + ".txt"))
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(fileName + ".txt");
            
            for (int i = 0; i < lines.Length; i += 4)
            {
                DateTime date = DateTime.Parse(lines[i]);
                string promptText = lines[i + 1];
                string entryText = lines[i + 2];

                Entry entry = new(date, promptText, entryText);
                _entries.Add(entry);
            }
        }
        
        else
        {
            Console.WriteLine("File not found. Try again.");
        }
    }
}