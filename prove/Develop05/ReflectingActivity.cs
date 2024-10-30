using System;

public class ReflectingActivity : Activity
{
    private static readonly List<string> Prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static readonly List<string> Questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What could you learn from this experience?"
    };

    public ReflectingActivity() : base("Reflection", "This activity helps you reflect on experiences of strength and resilience.")
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
        int questionIndex = 0;

        while (DateTime.Now < endTime)
        {
            Console.WriteLine(Questions[questionIndex]);
            ShowSpinner(5); 
            questionIndex = (questionIndex + 1) % Questions.Count;
        }

        DisplayEndingMessage();
    }
}