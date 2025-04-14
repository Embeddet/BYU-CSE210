using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Activities");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }
            else if (choice == "2")
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.Run();
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}

/* 
EXCEEDING REQUIREMENTS:
1. I added a spinner animation and countdown timer for all pauses to enhance user experience.
2. I included a random selection of prompts and questions for Reflection and Listing activities.
3. I allowed the user to specify the duration of each activity dynamically.
4. I added a feature in the Listing Activity to count and display the number of items listed by the user.
5. I designed the program with extensibility in mind by using a base `Activity` class and abstract methods, making it easy to add new activities in the future.
6. I used inheritance and encapsulation principles to avoid code duplication and ensure maintainability.
*/