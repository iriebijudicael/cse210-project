using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a reference
        Reference myObject1 = new Reference("John", 14, 26);
        //Reference myObject2 = new Reference("Proverbs", 3, 5, 6);


        Scripture scripture = new Scripture(myObject1, "But the Advocate, the Holy Spirit, whom the Father will send in my name, will teach you all things and will remind you of everything I have said to you.");
        //Scripture scripture = new Scripture(myObject2, "Trust in the Lord with all your heart and lean not on your own understanding in all your ways submit to him and he will make your paths straight");

        //Loop while To keep asking until the condition is made to break.
        while (true) 
        {
            Console.Clear();

            Console.WriteLine("Conplete Scripture:");
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\nPress ENRER to hide more words, or type 'quit' to exit ");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }

            if (string.IsNullOrEmpty(userInput))
            {
                scripture.HideRandomWords(3);

                if (scripture.IsCompletelyHidden())
                {
                    Console.Clear();
                    Console.WriteLine(scripture.GetDisplayText());
                    Console.WriteLine("\nWords are hidden, Exit");
                    break;
                }
            }

        }
	}
}
