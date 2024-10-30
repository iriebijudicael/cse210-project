using System;

public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void SetDuration()
    {
        Console.Write("Enter the duration for the activity in seconds: ");
        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            _duration = duration;
        }
        else
        {
            Console.WriteLine("Invalid input. Setting default duration to 60 seconds.");
            _duration = 60;
        }
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"\nActivity: {_name}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Duration: {_duration} seconds");
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        Console.WriteLine($"Activity completed: {_name}");
        Console.WriteLine($"Duration: {_duration} seconds");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int duration)
    {
        List<string> animationString = new List<string> { "|", "/", "-", "\\" };
        int animationIndex = 0;
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write(animationString[animationIndex]);
            Thread.Sleep(500); 
            Console.Write("\b \b");
            animationIndex = (animationIndex + 1) % animationString.Count;
        }
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    public abstract void Run();
}