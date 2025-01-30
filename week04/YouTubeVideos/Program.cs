using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create some sample comments
        var comment1 = new Comment("Alice", "Great video, very informative!");
        var comment2 = new Comment("Bob", "I learned so much from this!");
        var comment3 = new Comment("Charlie", "Thanks for sharing this, really helpful!");
        var comment4 = new Comment("David", "Interesting content, will watch again.");
        
        // Create some sample videos and add comments to them
        var video1 = new Video("Understanding C#", "John Doe", 180);
        video1.Comments.Add(comment1);
        video1.Comments.Add(comment2);

        var video2 = new Video("Advanced C# Tips", "Jane Smith", 240);
        video2.Comments.Add(comment3);
        video2.Comments.Add(comment4);

        // Create a list of videos
        var videos = new List<Video> { video1, video2 };

        // Display information for each video
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }
            Console.WriteLine(); // Add space between videos
        }
    }
}
