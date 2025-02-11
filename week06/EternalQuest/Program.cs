using System;

class Program
{
    static void Main(string[] args)
    {
        Quest quest = new Quest();

        SimpleGoal simpleGoal = new SimpleGoal("Run Marathon", "Complete a full marathon", 1000);
        EternalGoal eternalGoal = new EternalGoal("Read Scriptures", "Read scriptures daily", 100);
        ChecklistGoal checklistGoal = new ChecklistGoal("Attend Temple", "Attend the temple 10 times", 50, 10, 500);

        quest.AddGoal(simpleGoal);
        quest.AddGoal(eternalGoal);
        quest.AddGoal(checklistGoal);

        quest.DisplayGoals();
        quest.RecordGoalProgress("Read Scriptures");
        quest.SaveGoals();
    }
}
