using System;
using system.Collections.Generic;

public class Journal
{
    private List<Entry> entries = new List<Entry>();

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

    public void SveToFile(string filename)
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