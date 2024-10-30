using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by focusing on breathing.")
    {
    }

    public override void Run()
    {
        SetDuration();
        DisplayStartingMessage();

        int cycles = _duration / 6; 
        for (int i = 0; i < cycles; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(3);

            Console.WriteLine("Breathe out...");
            ShowCountdown(3);
        }

        DisplayEndingMessage();
    }
}