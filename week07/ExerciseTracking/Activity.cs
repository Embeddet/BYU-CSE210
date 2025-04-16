using System;

public abstract class Activity
{
    private DateTime _date;
    private int _length; // Length in minutes

    public Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public int GetLength()
    {
        return _length;
    }

    // Abstract methods to be implemented by derived classes
    public abstract double GetDistance(); // Distance in miles or kilometers
    public abstract double GetSpeed();    // Speed in mph or kph
    public abstract double GetPace();     // Pace in min per mile or min per km

    // Method to get the summary
    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} ({_length} min): Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace {GetPace():F2} min per mile";
    }
}