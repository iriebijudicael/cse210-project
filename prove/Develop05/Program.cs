using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        List<string> breathingPrompts = new List<string> { "Focus on your breath.", "Imagine your breath flowing through your body." };
        List<string> listingPrompts = new List<string> { "List your favorite foods.", "List your personal goals." };
        List<string> reflectingPrompts = new List<string> { "Think of a time when you felt proud.", "Recall a challenging situation you overcame." };
        List<string> reflectingQuestions = new List<string> { "How did you feel during this experience?", "What did you learn from it?" };

        BreathingActivity breathingActivity = new BreathingActivity();
        ListingActivity listingActivity = new ListingActivity(listingPrompts);
        ReflectingActivity reflectingActivity = new ReflectingActivity(reflectingPrompts, reflectingQuestions);

        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Listing");
            Console.WriteLine("3. Reflecting");
            Console.WriteLine("4. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    breathingActivity.Run();
                    break;
                case 2:
                    listingActivity.Run();
                    break;
                case 3:
                    reflectingActivity.Run();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}