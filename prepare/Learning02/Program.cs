using System;

class Program
{

    static void Main(string[] args)
    {
        
        Job myWork = new Job();
        myWork._company = "Google";
        myWork._jobTitle = "Web Design";
        myWork._startYear = 2021;
        myWork._endYear = 2024;


        Resume myResume = new Resume();
        myResume._name = "Irie";

        myResume._jobs.Add(myWork);

        myResume.Display();
    }
}