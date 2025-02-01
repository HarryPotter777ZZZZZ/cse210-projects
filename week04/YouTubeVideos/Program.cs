using System;
using System.Collections.Generic; // added by me
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
    

        using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>
        {
            new Video("Video 1", "Author 1", 300),
            new Video("Video 2", "Author 2", 450),
            new Video("Video 3", "Author 3", 600)
        };

        // Add comments to Video 1
        videos[0].AddComment(new Comment("Commenter 1", "Great video!"));
        videos[0].AddComment(new Comment("Commenter 2", "Very informative."));
        videos[0].AddComment(new Comment("Commenter 3", "Thanks for sharing!"));

        // Add comments to Video 2
        videos[1].AddComment(new Comment("Commenter 4", "Awesome content!"));
        videos[1].AddComment(new Comment("Commenter 5", "Well explained."));
        videos[1].AddComment(new Comment("Commenter 6", "Keep it up!"));

        // Add comments to Video 3
        videos[2].AddComment(new Comment("Commenter 7", "Fantastic video!"));
        videos[2].AddComment(new Comment("Commenter 8", "Very helpful."));
        videos[2].AddComment(new Comment("Commenter 9", "Looking forward to more!"));

        // Display information for each video
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"{comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}