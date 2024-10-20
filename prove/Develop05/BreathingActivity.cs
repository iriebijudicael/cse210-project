using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "Relax by focusing on your breath.", 60)
	{
	
	}

    public virtual void Run()
    {
        base.DisplayStartingMessage();

        for (int i = 0; i < _duration; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowSpinner(3);

            Console.WriteLine("Breathe out...");
            ShowSpinner(3);
        }

        base.DisplayEndingMessage();
    }
}