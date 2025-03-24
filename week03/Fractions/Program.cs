using System;

class Program
{
    static void Main()
    {
        // Test constructors
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(3, 4);

        // Initial values
        Console.WriteLine("Initial values:");
        DisplayFraction(f1);
        DisplayFraction(f2);
        DisplayFraction(f3);

        // Test setters
        f1.SetTop(2);
        f1.SetBottom(3);
        f2.SetBottom(2);
        
        Console.WriteLine("\nAfter modifications:");
        DisplayFraction(f1);
        DisplayFraction(f2);

        // Test edge case
        try
        {
            f3.SetBottom(0);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"\nError: {ex.Message}");
        }
    }

    static void DisplayFraction(Fraction f)
    {
        Console.WriteLine($"{f.GetFractionString()} = {f.GetDecimalValue():N2}");
    }
}

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        _top = numerator;
        _bottom = denominator;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public void SetBottom(int bottom)
    {
        if (bottom == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}