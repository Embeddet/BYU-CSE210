using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int magicNumber = random.Next(1, 101);
        int guess;

        Console.WriteLine("Guess the magic number between 1 and 100!");

        do
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (guess != magicNumber);
    }
}