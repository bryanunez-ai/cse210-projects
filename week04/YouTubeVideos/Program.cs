using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("C# Tutorial for Beginners", "Programming with Mosh", 3600);
        video1.AddComment(new Comment("Alice", "Great tutorial! Very helpful for beginners."));
        video1.AddComment(new Comment("Bob", "Clear explanations. Thanks for sharing!"));
        video1.AddComment(new Comment("Charlie", "This helped me understand classes better."));
        video1.AddComment(new Comment("Diana", "Please make more videos like this!"));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("10 Tips for Clean Code", "CodeAesthetic", 720);
        video2.AddComment(new Comment("Eve", "These tips changed how I write code!"));
        video2.AddComment(new Comment("Frank", "Tip #7 is a game changer."));
        video2.AddComment(new Comment("Grace", "I wish I learned this earlier in my career."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Understanding Abstraction", "CS Dojo", 900);
        video3.AddComment(new Comment("Henry", "Finally, abstraction makes sense to me!"));
        video3.AddComment(new Comment("Ivy", "The examples were very clear."));
        video3.AddComment(new Comment("Jack", "Could you do a video on polymorphism next?"));
        video3.AddComment(new Comment("Karen", "Excellent explanation, thank you!"));
        videos.Add(video3);

        // Video 4
        Video video4 = new Video("Data Structures Explained", "freeCodeCamp", 5400);
        video4.AddComment(new Comment("Leo", "This is the best DS video I've found!"));
        video4.AddComment(new Comment("Mia", "Very comprehensive coverage."));
        video4.AddComment(new Comment("Noah", "Helped me prepare for my interview."));
        videos.Add(video4);

        // Display all videos with their comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  - {comment.GetCommenterName()}: {comment.GetCommentText()}");
            }

            Console.WriteLine();
        }
    }
}