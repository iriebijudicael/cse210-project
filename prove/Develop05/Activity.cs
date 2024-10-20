using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine("Activity: " + _name);
        Console.WriteLine("Description: " + _description);
        Console.WriteLine("Duration: " + _duration + " seconds");
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3); 
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        Console.WriteLine("Activity completed: " + _name);
        Console.WriteLine("Duration: " + _duration + " seconds");
        ShowSpinner(3); 
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("|");
            Thread.Sleep(1000);
            Console.Write("\b");
        }
        Console.WriteLine();
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
            Console.Write("\b");
        }
        Console.WriteLine();
    }
}