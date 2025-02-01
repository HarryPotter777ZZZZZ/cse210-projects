using System;
using System.Collections.Generic; // added by me
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
    

        List<Video> videos = newList<Video>
        {
        new Video("Video 1", "Author 1", 300),
        new Video("Video 2", "Authir 2", 450), 
        new Video("Video 3", "Author 3", 600) 
        }

        // Add comments Video 1
        videos[0].AddComment(new Comment("Comment 1", "Great video!"));
        videos[0].AddComment(new Comment("Comment 2", "Very informative."));
        videos[0].AddComment(new Comment("Comment 3", "Thanks for sharing!"));

        // Add comments to Video 2
        videos[1].AddComment(new Comment("Comment 1", "Awesome content!"));
        videos[1].AddComment(new Comment("Comment 2", "Well explained."));
        videos[1].AddComment(new Comment("Comment 3", "Keep it up!"));

        // Add comments to Video 3
        videos[2].AddComment(new Comment("Comment 1", "Fantastic video!"));
        videos[2].AddComment(new Comment("Comment 2", "Very helpful."));
        videos[2].AddComment(new Comment("Comment 3", "Looking forward to more!"));

        // Display info for each Video
        foreach (var videp in videos)
        {
            Console.WriteLine($"Title: (video.Title)");
            Console.WriteLine($"Author: (video.Author)");
            Console.WriteLine($"Length: (video.Length)");
            Console.WriteLine($"Number of Comments: (video.GetNumberOfComments())");
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"{comment.CommenterName}: {comment.Text} ");
            }
            Console.WriteLine();
        }
    }
}