using System;

class Program
{
    static void Main(string[] args)
    {
        //GPA requirement to move forward with Conditionals if, else and else if.

        Console.WriteLine("What is your grade percentage? ");
        string answer = Console.ReadLine();

        int gradePercent = int.Parse(answer);

        string prompt = "";

        if (gradePercent >= 90)
        {
            prompt = "A";
        }
        else if (gradePercent >= 80)
        {
            prompt = "B";
        }
        else if (gradePercent >= 70)
        {
            prompt = "C";
        }
        else if (gradePercent >= 60)
        {
            prompt = "D";
        }
        else
        {
            prompt = "F";
        }

        Console.WriteLine($"Your grade is: {prompt}");
        
        if (gradePercent >= 70)
        {
            Console.WriteLine("Great work, You passed!");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass, Better luck next time!");
        }


		

  
        //Booking a travail day with conditionals if, else, else if.
		/*Console.WriteLine("Day of selling ticket: 1, 4, 7, 18, 20, 29, 30");
        Console.Write("Please pick a number from this list ");
        string date = Console.ReadLine();
        int user = int.Parse(date);

        string day = "";

        if (user >= 29)
        {
            day = "Mondy";
        }
        else if (user >= 20)
        {
            day = "Tuesday";
        }
        else if (user >= 18)
        {
            day = "Wednesday";
        }
        else if (user >= 7)
        {
            day = "Thursday";
        }
        else if (user >= 5)
        {
            day = "Friday";
        }
        else if (user >= 4)
        {
            day = "Saturday";
        }
        else
        {
            day = "Sunday";
        }

        Console.WriteLine($"Your day is: {day}");

        if (user >= 5)
        {
            Console.WriteLine($"{user}, is a Good day to take a ticket");
        }
        else
        {
            Console.WriteLine("Sorry, the fly Ticket is out!");
        }*/
    

    }
}