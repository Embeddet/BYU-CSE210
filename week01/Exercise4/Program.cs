using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number;
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            
            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);

        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers entered.");
            return;
        }

        // Calculate sum
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        // Calculate average
        double average = (double)sum / numbers.Count;

        // Find maximum
        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }

        // Display results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}