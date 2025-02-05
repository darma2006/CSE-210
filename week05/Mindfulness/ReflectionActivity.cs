using System;
using System.Threading;

public class ReflectionActivity : MindfulnessActivity
{
    public ReflectionActivity(int duration) : base(duration) {}

    public override void StartActivity()
    {
        base.StartActivity();
        string[] prompts = {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need."
        };

        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Length)];

        Console.WriteLine(prompt);
        Pause();
        for (int i = 0; i < duration; i++)  // Loop to show reflection questions
        {
            Console.WriteLine("Reflect on the following:");
            Console.WriteLine("Why was this experience meaningful to you?");
            Pause();
        }

        EndActivity();
    }
}
