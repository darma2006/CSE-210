public class ChecklistGoal : Goal
{
    public int TimesCompleted { get; set; }
    public int TotalTimes { get; set; }
    public int BonusPoints { get; set; }

    public ChecklistGoal(string name, string description, int points, int totalTimes, int bonusPoints)
        : base(name, description, points)
    {
        TotalTimes = totalTimes;
        BonusPoints = bonusPoints;
        TimesCompleted = 0;
    }

    public override void RecordProgress()
    {
        if (TimesCompleted < TotalTimes)
        {
            TimesCompleted++;
            Console.WriteLine($"{Name}: Completed {TimesCompleted}/{TotalTimes} - {Points} points earned.");
            if (TimesCompleted == TotalTimes)
            {
                Console.WriteLine($"Bonus! {BonusPoints} extra points earned for completing {Name}.");
            }
        }
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"{Name}: {Description} (Points: {Points}, Total Times: {TotalTimes}, Completed: {TimesCompleted})");
    }

    public override string GetProgress()
    {
        return $"Completed {TimesCompleted}/{TotalTimes} times";
    }
}
