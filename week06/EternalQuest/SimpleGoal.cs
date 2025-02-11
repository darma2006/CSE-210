public class SimpleGoal : Goal
{
    public bool IsComplete { get; set; }

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        IsComplete = false;
    }

    public override void RecordProgress()
    {
        if (!IsComplete)
        {
            IsComplete = true;
            Console.WriteLine($"{Name} is now complete! You earn {Points} points.");
        }
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"{Name}: {Description} (Points: {Points}) - Completed: {IsComplete}");
    }

    public override string GetProgress()
    {
        return IsComplete ? "Completed" : "Not Completed";
    }
}
