using System;

class Program
{
    static void Main(string[] args)
    {
        // Create 3-4 videos, set the appropriate values, and for each one add a list of 3-4 comments 
        // (with the commenter's name and text). Put each of these videos in a list.
        List<Video> videos = new List<Video>();

        Video video1 = new Video();

        video1.Title = "Video 1";
        video1.Author = "Author 1";
        video1.Length = 120;

        video1.AddComment(new Comment {CommenterName = "User1", CommentText = "Amazing!"});
        video1.AddComment(new Comment {CommenterName = "User2", CommentText = "Great!"});
        video1.AddComment(new Comment {CommenterName = "User3", CommentText = "Cool!"});

        videos.Add(video1);


        Video video2 = new Video();

        video2.Title = "Video 2";
        video2.Author = "Author 2";
        video2.Length = 1000;

        video2.AddComment(new Comment {CommenterName = "User1", CommentText = "Dislike!"});
        video2.AddComment(new Comment {CommenterName = "User2", CommentText = "Waste of time"});
        video2.AddComment(new Comment {CommenterName = "User3", CommentText = "Oh no!"});
        video2.AddComment(new Comment {CommenterName = "User4", CommentText = "The worst video ever"});

        videos.Add(video2);


        Video video3 = new Video();

        video3.Title = "Video 3";
        video3.Author = "Author 3";
        video3.Length = 30;

        video3.AddComment(new Comment {CommenterName = "User1", CommentText = "Hilarious"});
        video3.AddComment(new Comment {CommenterName = "User2", CommentText = "Lol"});
        video3.AddComment(new Comment {CommenterName = "User3", CommentText = "hahahah"});

        videos.Add(video3);

        // iterate through the list of videos and for each one, display the title, author, length, number of comments 
        // (from the method) and then list out all of the comments for that video. Repeat this display for each video in the list.
        foreach (var video in videos)
        {
            Console.WriteLine($"Video Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} minutes");
            Console.WriteLine($"Number of Comments: {video.CountComments()}");

            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"{comment.CommenterName}: {comment.CommentText}");
            }

            Console.WriteLine();
        }
    }
}