using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(List<string> prompts, List<string> questions) : base("Reflecting", "Reflect on a past experience.", 60)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public override void Run ()
    {
        base.DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        Console.WriteLine("Prompt: " + prompt);

        DisplayQuestions();

        base.DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    private void DisplayQuestions()
    {
        foreach (string question in _questions)
        {
            Console.WriteLine(question);
            ShowSpinner(5);
        }
    }
}