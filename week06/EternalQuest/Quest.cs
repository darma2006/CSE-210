using System;
using System.Collections.Generic;

public class Quest
{
    public List<Goal> Goals { get; set; }
    public int TotalPoints { get; set; }

    public Quest()
    {
        Goals = new List<Goal>();
        TotalPoints = 0;
    }

    public void AddGoal(Goal goal)
    {
        Goals.Add(goal);
    }

    public void DisplayGoals()
    {
        foreach (var goal in Goals)
        {
            goal.DisplayGoal();
        }
    }

    public void RecordGoalProgress(string goalName)
    {
        var goal = Goals.Find(g => g.Name == goalName);
        if (goal != null)
        {
            goal.RecordProgress();
            TotalPoints += goal.Points;
        }
        else
        {
            Console.WriteLine("Goal not found.");
        }
    }

    public void SaveGoals()
    {
    }

    public void LoadGoals()
    {
    }
}
