using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Eternal Quest");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Quit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Select Goal Type:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                string goalType = Console.ReadLine();

                Console.Write("Enter goal name: ");
                string name = Console.ReadLine();
                Console.Write("Enter goal description: ");
                string description = Console.ReadLine();
                Console.Write("Enter points: ");
                int points = int.Parse(Console.ReadLine());

                if (goalType == "1")
                {
                    goalManager.AddGoal(new SimpleGoal(name, description, points));
                }
                else if (goalType == "2")
                {
                    goalManager.AddGoal(new EternalGoal(name, description, points));
                }
                else if (goalType == "3")
                {
                    Console.Write("Enter target count: ");
                    int targetCount = int.Parse(Console.ReadLine());
                    Console.Write("Enter bonus points: ");
                    int bonusPoints = int.Parse(Console.ReadLine());
                    goalManager.AddGoal(new ChecklistGoal(name, description, points, targetCount, bonusPoints));
                }
            }
            else if (choice == "2")
            {
                goalManager.DisplayGoals();
                Console.Write("Enter the number of the goal to record: ");
                int goalIndex = int.Parse(Console.ReadLine()) - 1;
                goalManager.RecordEvent(goalIndex);
            }
            else if (choice == "3")
            {
                goalManager.DisplayGoals();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
            else if (choice == "4")
            {
                goalManager.DisplayScore();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
            else if (choice == "5")
            {
                break;
            }
        }
    }
}

/*
EXCEEDING REQUIREMENTS:
1. Added a `GoalManager` class to encapsulate goal management and score tracking.
2. Included bonus points for completing checklist goals.
3. Designed the program to be extensible for adding new goal types in the future.
4. Used polymorphism to handle different goal types dynamically.
*/