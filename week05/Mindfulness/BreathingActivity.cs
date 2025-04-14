using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void Run()
    {
        Start();
        int duration = GetDuration();
        int elapsed = 0;

        while (elapsed < duration)
        {
            Console.Write("Breathe in...");
            ShowCountdown(4);
            Console.Write("Breathe out...");
            ShowCountdown(6);
            elapsed += 10;
        }

        End();
    }
}