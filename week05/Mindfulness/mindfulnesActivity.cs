using System;
using System.Threading;

public class MindfulnessActivity
{
    protected int duration;

    // Constructor to set the duration
    public MindfulnessActivity(int duration)
    {
        this.duration = duration;
    }

    // Common method to start an activity (this will be overridden in the subclasses)
    public virtual void StartActivity()
    {
        Console.WriteLine("Starting activity...");
        Thread.Sleep(2000);  // Simulate waiting before the activity begins
    }

    // Pause method to simulate delays
    protected void Pause()
    {
        Thread.Sleep(1000);  // Placeholder for pause
    }

    // Common method to end any activity
    public virtual void EndActivity()
    {
        Console.WriteLine("You have completed the activity!");
        Thread.Sleep(2000);  // Pause before completing the activity
    }
}
