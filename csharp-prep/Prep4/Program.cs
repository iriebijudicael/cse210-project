using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Ask user for a sList of numbers
        List<int> numbers = new List<int>();
        int number;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }

        } while (number != 0); 

       
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        
        double grade = 0;
        if (numbers.Count > 0) 
        {
            grade = (double)sum / numbers.Count;
        }

        
        int max = int.MinValue;
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }

       
        Console.WriteLine($"\nThe sum is: {sum}");
        Console.WriteLine($"The average is: {grade}");
        Console.WriteLine($"The largest number is: {max}");
    }
}
