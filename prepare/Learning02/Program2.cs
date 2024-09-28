using System;

class Program
{

    static void Main(string[] args)
    {
        Journal thejournal = new Journal();
        Entry anEntry = new Entry();

        Console.WriteLine("Hello, welcome to week02");
        Console.WriteLine("Let us have a personal daily journal");


        anEntry.Display();
    }
}