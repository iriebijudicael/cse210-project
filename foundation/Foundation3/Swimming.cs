using System;

public class Swimming : Activity
{
    private int _laps;
    private const double LapLengthKm = 0.05; 

    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance() => _laps * LapLengthKm;
    public override double GetSpeed() => (GetDistance() / Duration) * 60;
    public override double GetPace() => Duration / GetDistance();
}