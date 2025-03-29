using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store videos
        List<Video> videos = new List<Video>();

        // Create videos
        Video video1 = new Video("How to Cook Pasta", "Chef John", 300);
        Video video2 = new Video("Top 10 Travel Destinations", "Travel Guru", 600);
        Video video3 = new Video("Learn C# in 10 Minutes", "Code Academy", 720);

        // Add comments to video1
        video1.AddComment(new Comment("Alice", "Great recipe!"));
        video1.AddComment(new Comment("Bob", "Tried it, and it was amazing!"));
        video1.AddComment(new Comment("Charlie", "Can you make a gluten-free version?"));

        // Add comments to video2
        video2.AddComment(new Comment("Dave", "I want to visit all these places!"));
        video2.AddComment(new Comment("Eve", "Number 3 is my favorite."));
        video2.AddComment(new Comment("Frank", "Great video, very inspiring!"));

        // Add comments to video3
        video3.AddComment(new Comment("Grace", "This was super helpful, thanks!"));
        video3.AddComment(new Comment("Hank", "I learned so much in just 10 minutes."));
        video3.AddComment(new Comment("Ivy", "Can you make a video on advanced topics?"));

        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display video details and comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}