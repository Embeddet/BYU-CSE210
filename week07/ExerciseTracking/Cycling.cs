public class Cycling : Activity
{
    private double _speed; // Speed in mph

    public Cycling(DateTime date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (GetSpeed() * GetLength()) / 60; // Distance = (speed * time) / 60
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed(); // Pace = 60 / speed
    }
}