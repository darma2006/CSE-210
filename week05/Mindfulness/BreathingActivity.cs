using System;
using System.Threading;

public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity(int duration) : base(duration) {}

    public override void StartActivity()
    {
        base.StartActivity();
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly.");
        Console.Write("Please enter the duration (in seconds): ");
        this.duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready to begin...");
        Pause();

        for (int i = 0; i < duration; i++)  // Loop to alternate breathing instructions
        {
            Console.WriteLine("Breathe in...");
            Pause();
            Console.WriteLine("Breathe out...");
            Pause();
        }

        EndActivity();
    }
}
