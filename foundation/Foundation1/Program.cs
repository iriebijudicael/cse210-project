using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Create videos and add comments
        videos.Add(new Video { Title = "Amazing Video", Author = "Irie Judicael", LengthInSeconds =120});
        videos.Add(new Video { Title = "Another Great Video", Author = "Viviane", LengthInSeconds =320});
		videos.Add(new Video { Title = "Another Great Video", Author = "Elvis", LengthInSeconds =40});

        // Add comments to each video
        videos[0].Comments.Add(new Comment { Name = "User1", Text = "This video is amazing!"});
		videos[1].Comments.Add(new Comment { Name = "User2", Text = "Wow I love this video!"});
		videos[2].Comments.Add(new Comment { Name = "User3", Text = "I played this video over over again!"});
      

        // Display video information
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"  Name: {comment.Name}");
                Console.WriteLine($"  Text: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}