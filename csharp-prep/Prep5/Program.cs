using System;

class Program
{
    static void Main(string[] args)
    {
        // How to use function from assigment requirements. 
        DisplayWelcome();

       //1- ask user name
        string userName = PromptUserName();

        //2- ask user number
        int favoriteNumber = PromptUserNumber();

       //Both informatio display with user square number
        int squaredNumber = SquareNumber(favoriteNumber);
 
    
        DisplayResult(userName, squaredNumber);
    }


    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome in this Program!");
    }


    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }


    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}
