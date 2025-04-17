using System;

public class Swimming : Activity
{
    private int _numberOfLaps;

    public Swimming(DateTime date, int lengthInMinutes, int numberOfLaps)
        : base(date, lengthInMinutes)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double GetDistance()
    {
        double meters = _numberOfLaps * 50;
        return meters / 1000 * 0.62; // km to miles
    }

    public override double GetSpeed() => (GetDistance() / LengthInMinutes) * 60;

    public override double GetPace() => LengthInMinutes / GetDistance();
}
