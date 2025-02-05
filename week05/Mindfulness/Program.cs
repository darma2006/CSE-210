using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Welcome to the Mindfulness Program");
        Console.WriteLine("Choose an activity: 1. Breathing 2. Reflection 3. Listing");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter duration for activity (in seconds): ");
        int duration = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            BreathingActivity breathing = new BreathingActivity(duration);
            breathing.StartActivity();
        }
        else if (choice == 2)
        {
            ReflectionActivity reflection = new ReflectionActivity(duration);
            reflection.StartActivity();
        }
        else if (choice == 3)
        {
            ListingActivity listing = new ListingActivity(duration);
            listing.StartActivity();
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }
}
