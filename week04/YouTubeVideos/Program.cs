using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        var videos = new List<Video>
        {
            new Video("Intro to C#",       "Jane Doe",     300),
            new Video("OOP Fundamentals",  "John Smith",   540),
            new Video("LINQ Deep Dive",    "Alice Johnson",780)
        };

        // Add comments to each video
        videos[0].AddComment(new Comment("Sam",   "Great intro!"));
        videos[0].AddComment(new Comment("Kelly", "Very clear explanation."));
        videos[0].AddComment(new Comment("Lee",   "Saved me a ton of time, thanks!"));

        videos[1].AddComment(new Comment("Pat",   "Inheritance still confuses me."));
        videos[1].AddComment(new Comment("Riley", "Nice examples on polymorphism."));
        videos[1].AddComment(new Comment("Jordan","Could you do a live demo?"));

        videos[2].AddComment(new Comment("Chris",  "LINQ is powerful."));
        videos[2].AddComment(new Comment("Morgan", "I prefer query syntax."));
        videos[2].AddComment(new Comment("Taylor", "What about performance?"));
        videos[2].AddComment(new Comment("Alex",   "Thanks for this deep dive."));

        // Display each video's info and comments
        foreach (var video in videos)
        {
            Console.WriteLine($"Title:  {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Comments ({video.GetNumberOfComments()}):");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"  - {comment.AuthorName}: \"{comment.Text}\"");
            }
            Console.WriteLine(new string('-', 40));
        }
    }
}