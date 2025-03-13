using System;

class Program
{
    static void Main(string[] args)
    {
       /*int A = 90;
        int B = 80;
        int C = 70;
        int D = 60;
        int F = 60;*/

 Console.Write("What is your Score? ");
        string answer = Console.ReadLine();
        int score = int.Parse(answer);

         if (score >= 90)
        {
            Console.WriteLine($"Your grade is A");
            Console.WriteLine("You passed!");
        }
        else if (score >= 80)
        {
             Console.WriteLine($"Your grade is B");
             Console.WriteLine("You passed!");
        }
        else if (score >= 70)
        {
            Console.WriteLine($"Your grade is C");
             Console.WriteLine("You passed!");
        }
        else if (score >= 60)
        {
            Console.WriteLine($"Your grade is D ");
            Console.WriteLine("Better luck next time!");
        }
        else if (score <= 60)
        {
            Console.WriteLine($"Your grade is F ");
            Console.WriteLine("Better luck next time!");
        }

        
    }
}