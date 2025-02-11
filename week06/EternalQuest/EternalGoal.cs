public class EternalGoal : Goal
{
    public int TimesRecorded { get; set; }

    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
        TimesRecorded = 0;
    }

    public override void RecordProgress()
    {
        TimesRecorded++;
        Console.WriteLine($"Progress recorded for {Name}. {TimesRecorded} times completed. {Points} points earned each time.");
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"{Name}: {Description} (Points: {Points}) - Times Recorded: {TimesRecorded}");
    }

    public override string GetProgress()
    {
        return $"Recorded {TimesRecorded} times";
    }
}
