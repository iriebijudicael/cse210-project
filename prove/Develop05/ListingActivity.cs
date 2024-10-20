using System;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private int _count;

    public ListingActivity(List<string> prompts) : base("Listing", "List as many items as you can.", 60)
    {
        _prompts = prompts;
        _count = 0;
    }

    public override void Run ()
    {
        base.DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        Console.WriteLine("Prompt: " + prompt);

        List<string> items = GetListFromUser();

        Console.WriteLine("You listed " + items.Count + " items.");

        base.DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    private List<string> GetListFromUser()
    {
        List<string> items = new List<string>();

        Console.WriteLine("Start listing items (enter 'done' to finish):");

        while (true)
        {
            string item = Console.ReadLine();
            if (item.ToLower() == "done")
            {
                break;
            }
            items.Add(item);
            _count++;
        }

        return items;
    }
}