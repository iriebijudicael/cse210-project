using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
         
        //Booking a travel day with a list of valid day
        Console.WriteLine("\nDay of selling ticket: 1, 4, 7, 18, 20, 29, 30");
		
		List<int> validDays = new List<int> {1, 4, 7, 18, 20, 29};
        
		//User have to tape a valid day
        Console.WriteLine("Please pick a valid number from this list");
        string date = Console.ReadLine();
        int user = int.Parse(date);
		
        if (validDays.Contains(user))
		{
			string day = "";

            if (user >= 29)
            {
                day = "Monday";
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
                 Console.WriteLine($"{user}, is a Good day to have a ticket.");
            }
            else
            {
            Console.WriteLine("Sorry, the flight ticket is out!");
            }
		}
        
        else 
        {
            Console.WriteLine("Day selected by error. Please restart the program and choose a valid day");
        }
		
	}
    
}