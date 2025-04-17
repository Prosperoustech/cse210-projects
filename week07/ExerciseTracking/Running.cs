using System;

public class Running : Activity
{
    private double _distanceInMiles;

    public Running(DateTime date, int lengthInMinutes, double distanceInMiles)
        : base(date, lengthInMinutes)
    {
        _distanceInMiles = distanceInMiles;
    }

    public override double GetDistance() => _distanceInMiles;

    public override double GetSpeed() => (_distanceInMiles / LengthInMinutes) * 60;

    public override double GetPace() => LengthInMinutes / _distanceInMiles;
}