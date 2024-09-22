using System;

class Program
{
    static void Main(string[] args)
   {

       //Using while loop for Student to pick any randomnumber to earn a scholarship
	   
	   Random random = new Random();
       int magicNumber = random.Next(1, 101);

       int guess = -1;

        while (guess != magicNumber)
        {
			
            Console.WriteLine("What is your guess number? ");
			string userNumber = Console.ReadLine();
			
            int userGuess = int.Parse(userNumber);

            if (guess > magicNumber)
            {
                Console.WriteLine("Too low, try again!:");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Too high, try again!:");
            }
            else 
            {
                Console.WriteLine("Great, you guessed it!:");
            }
			
		}



        //Using For loop to allow multiples entries and increment each of them
        /*Console.WriteLine("What is your final grade ? ");
		
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
        }*/


    }
}