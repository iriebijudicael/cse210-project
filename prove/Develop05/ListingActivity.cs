using System;

public class ListingActivity : Activity
{
    private static readonly List<string> Prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people you have helped this week?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity helps you list things you are grateful for.")
    {
    }

    public override void Run()
    {
        SetDuration();
        DisplayStartingMessage();

        string prompt = Prompts[new Random().Next(Prompts.Count)];
        Console.WriteLine($"Prompt: {prompt}");
        ShowCountdown(5);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        List<string> items = new List<string>();
        
        Console.WriteLine("Start listing items (enter 'done' to finish):");
        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            if (item.ToLower() == "done")
            {
                break;
            }
            items.Add(item);
        }

        Console.WriteLine($"You listed {items.Count} items.");
        DisplayEndingMessage();
    }
}