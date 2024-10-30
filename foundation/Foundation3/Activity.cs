using System;

public class Activity
{
    public DateTime Date { get; set; }
    public int Duration { get; set; } 

    public Activity(DateTime date, int duration)
    {
        Date = date;
        Duration = duration;
    }

    public virtual double GetDistance() => 0;
    public virtual double GetSpeed() => 0;
    public virtual double GetPace() => 0;

    public virtual string GetSummary()
    {
        return $"{Date:dd MMM yyyy} {GetType().Name} ({Duration} min) - Distance: {GetDistance():0.0} km, " +
               $"Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min/km";
    }
}