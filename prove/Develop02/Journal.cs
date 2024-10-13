using System;


/*class Journal
{
    private List<(string prompt, string response)> entries = new List<(string prompt, string response)>();

    public void AddEntry(string prompt, string response)
    {
        entries.Add((prompt, response));
    }

    public void DisplayJournal()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine($"Prompt: {entry.prompt}, Response: {entry.response}");
        }
    }

    public void SaveToFile(string filename)
    {
        // implement saving to file
    }

    public void LoadJournalFile(string filename)
    {
        // implement loading from file
    }
}*/


public class Journal
{
    public List<Entry> entries = new List<Entry>();

    public void AddEntry(string prompt, string response)
    {
        Enter newEntry = new Enter(prompt, response);
        entries.Add(newEntry);
    }

    public void DisplayJournal()
    {
        foreach (Entry entry in entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWrite Write = new StreamWrite(filename))
        {
            foreach (Entry entry in entries)
            {
                Write.WriteLine($"{entry.Date},{entry.Prompt},{entry.Response}");
            }
        }
    }

    
    public void LoadFromFile(string filename)
    {
        entries.Clear();
        string[] lines = File.ReadAllLines();
        foreach (string line in lines)
        {
            string parts = line.Split(",");
            DateTime date = DateTime.Parse(parts);
        }
    }
}