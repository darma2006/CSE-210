using System;
using System.Threading;

public class ListingActivity : MindfulnessActivity
{
    public ListingActivity(int duration) : base(duration) {}

    public override void StartActivity()
    {
        base.StartActivity();
        string[] prompts = {
            "Who are people that you appreciate?",
            "What are your personal strengths?"
        };

        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Length)];

        Console.WriteLine(prompt);
        Pause();
        Console.WriteLine("Start listing now!");
        
        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Enter item: ");
            Console.ReadLine();  // Accept user input for each item
            count++;
        }

        Console.WriteLine($"You listed {count} items.");
        EndActivity();
    }
}
