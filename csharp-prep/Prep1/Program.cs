using System;

class Program
{
    static void Main(string[] args)
    {   
        //// Prompt the user for the full name and age
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        Console.Write("How old are you now ? ");
        string age = Console.ReadLine();

        Console.WriteLine($"Your name is {first} {last} and you are {age} years old.");



        //Aske user to Records some data with Variable, Input and Output.
        /*Console.WriteLine("\nWhich Job do you do ? ");
        string job = Console.ReadLine();

        Console.WriteLine("\nHow much is the salary ? ");
        int salary = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nPlease, next tape the currency sign ? ");
        char sign = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("\nHow many Kilometer before to get to the workplace ? ");
        double kilometer = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Everyday you go about {kilometer} Km to the {job} work, For a month salary of {salary}{sign}");*/

        

        //Aske user to tape some data.
       /* Console.WriteLine("What do you study at BYU? ");
        string course = Console.ReadLine();

        Console.WriteLine("How much is the course each semester ? ");
        double price = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("From this list [A, A-, B, B-, C, C-, D, D-, F] pick your GPA" );
        char gpa = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("How many Credits did you take ? ");
        int credits = Convert.Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"This semester you start with {course}, for paying $ {price} and your GPA is {gpa} over {credits} out of 38 credits");*/
    }
}