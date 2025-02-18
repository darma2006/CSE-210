using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        var activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 3.0), // 3 miles run
            new Cycling(new DateTime(2022, 11, 3), 45, 20.0), // 20 km/h cycling
            new Swimming(new DateTime(2022, 11, 3), 60, 40) // 40 laps swimming
        };

        // Iterating through the list and printing the summary of each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
