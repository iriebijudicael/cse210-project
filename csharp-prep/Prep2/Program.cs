using System;

class Program
{
    static void Main(string[] args)
    {
        //GPA requirement to move forward with Conditionals if, else and else if.
        /*Console.WriteLine("What is your grade? " );
        string grade = Console.ReadLine();

        int x = 100;
		x = int.Parse(grade);
        if (x>80)
        {
           Console.WriteLine("You have done great, good work!"); 
        }
		else if (x<50)
		{
		    Console.WriteLine("Sorry, next time you have to do better");
		}
		else
		{
			Console.WriteLine("Great you have validated the semester!");
		}*/
		

  
        //Booking a travail day with conditionals if, else, else if.
		Console.WriteLine("Day of selling ticket: 1, 4, 7, 18, 20, 29, 30");
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
        }
    

    }
}