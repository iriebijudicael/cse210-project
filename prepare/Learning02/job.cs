using System;

public class Job
{
    public  string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"I worked to {_company} as a {_jobTitle}, and I started on {_startYear} to end {_endYear}.");
    }

}