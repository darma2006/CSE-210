using System;
using System.Threading;

public static class AnimationHelpers
{
    // Show a simple spinner animation during pauses
    public static void ShowSpinner(int durationInSeconds)
    {
        string[] spinner = { "/", "-", "\\", "|" };
        int counter = 0;
        
        DateTime endTime = DateTime.Now.AddSeconds(durationInSeconds);

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[counter % 4]);
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the spinner character
            counter++;
        }
    }
}
