public class Running : Activity
{
    private double _distance; // Distance in miles

    public Running(DateTime date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetLength()) * 60; // Speed = (distance / time) * 60
    }

    public override double GetPace()
    {
        return GetLength() / GetDistance(); // Pace = time / distance
    }
}