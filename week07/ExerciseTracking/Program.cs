using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold activities
        List<Activity> activities = new List<Activity>();

        // Add a Running activity
        activities.Add(new Running(new DateTime(2022, 11, 3), 30, 3.0)); // 3 miles in 30 minutes

        // Add a Cycling activity
        activities.Add(new Cycling(new DateTime(2022, 11, 3), 45, 15.0)); // 15 mph for 45 minutes

        // Add a Swimming activity
        activities.Add(new Swimming(new DateTime(2022, 11, 3), 20, 30)); // 30 laps in 20 minutes

        // Iterate through the list and display summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}