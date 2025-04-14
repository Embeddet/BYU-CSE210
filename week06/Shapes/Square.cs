public class Square : Shape
{
    private double _side;

    // Constructor that calls the base class constructor
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // Override the GetArea method to calculate the area of the square
    public override double GetArea()
    {
        return _side * _side;
    }
}