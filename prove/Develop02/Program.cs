using System;
using System.Collections.Generic;

class Program
{

    static List<string> prompts = new List<string>;
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
    };

    static Journal journal = new Journal();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Choose an option: ");

            string userChoice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteEntry();
                    break;
                case "2":
                    journal.DisplayJournal();
                    break;
                case "3":
                    saveJournal();
                    break;
                case "4":
                    loadJournal();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    static void WriteEntry()
    {
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Count)];
        Console.WriteLine(prompt);
        string response = Console.ReadLine();

        journal.AddEntry(prompt, response);
    }

    static void SaveJournal()
    {
        Console.WriteLine("Enter the filename to save to: ");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
        Console.WriteLine("Journal saved.");
    }

    static void LoadJournal()
    {
        Console.WriteLine("Enter the filename to load from: ");
        string filename = Console.ReadLine();
        journal.LoadJournalFile(filename);
        Console.WriteLine("Journal loaded.");
    }
}