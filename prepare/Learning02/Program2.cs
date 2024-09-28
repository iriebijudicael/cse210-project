using System;

class Program
{

    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Entry userEntry = new Entry();

        Console.WriteLine("Hello, welcome to week02");
        Console.WriteLine("Let us have a personal daily journal");


        userEntry.Display();
    }
}