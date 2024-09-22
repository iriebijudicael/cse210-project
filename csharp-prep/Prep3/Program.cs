using System;

class Program
{
    static void Main(string[] args)
   {
        //Using For loop to allow multiples entries and increment each of them
        Console.WriteLine("What is your final grade ? ");
		
        for (i = 1, i <= 10, i=i+1)
        {
            Console.Write($"\nTape student grade here {i}: ");
            string grade = Console.ReadLine();
            int x = int.Parse(grade);

            if (x > 80)
            {
                Console.WriteLine("You have done great, good work!");
            }
            else if (x < 50)
            {
                Console.WriteLine("Sorry, next time you have to do better.");
            }
            else
            {
                Console.WriteLine("Great! You have validated the semester.");
            }
        }



        //Using while loop for Student to pick any randomnumber to earn a scholarship.
       /* Console.WriteLine("BYU-idaho decided to reward his marvelous student with scholarship:");
        int random = random.Next(1,11); 
        while (userGuess != randomNumber)
        {
			
            Console.WriteLine("Guess a numeber between 1 and 10: ");
            userGuess = int.Parse(Consol.ReadLine());

            if (userGuess < randomNumber)
            {
                Console.WriteLine("Too low, try again!:");
            }
            else if (userGuess < randomNumber);
            {
                Console.WriteLine("Too high, try again!:");
            }
        }*/
    }
}