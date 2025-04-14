using System;

public class Circle : Shape
{
    private double _radius;

    // Constructor that calls the base class constructor
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // Override the GetArea method to calculate the area of the circle
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}