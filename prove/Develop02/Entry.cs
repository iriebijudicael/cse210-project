using System;


public class Entry
{
    public string Prompt ( get; set )
    public string Response ( get; set )
    public string DateTime Date ( get; set )


    public Entry(string prompt, string response)
    {
        Prompt = prompt;
        Response = response;
        Date = DateTime.New;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
    }
}
