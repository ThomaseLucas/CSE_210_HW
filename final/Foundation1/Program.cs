using System;
using System.Collections.Generic;

namespace Foundation1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Video> videos = new List<Video>();

            Video video1 = new Video
            {
                videoAuthor = "NBC Nightly News",
                videoName = "Bear eats potato chips in a car.",
                videoTime = 180,
                Comments = new List<Comment>()
            };
            video1.Comments.Add(new Comment {commentAuthor = "Cooldad123", commentText = "I never thought a bear would do that hahaha"});
            video1.Comments.Add(new Comment {commentAuthor = "Meany24", commentText = "What an idiot! Shouldn't have had chips in his car!!"});
            video1.Comments.Add(new Comment {commentAuthor = "sweaty345", commentText = "Awwww, now I need to get a pet bear. <3"});
            
            videos.Add(video1);

            Video video2 = new Video
            {
                videoAuthor = "Monkey Lover234",
                videoName = "Dancing Monkey",
                videoTime = 24,
                Comments = new List<Comment>()
            };
            video2.Comments.Add(new Comment{commentAuthor = "goobi313", commentText = "How funny lol"});
            video2.Comments.Add(new Comment{commentAuthor = "woobie25", commentText = "I only dream of dancing like that!"});
            video2.Comments.Add(new Comment{commentAuthor = "Mark34", commentText = " I want my monkey to do that!"});
            videos.Add(video2);

            Video video3 = new Video
            {
                videoAuthor = "Programming with Classes",
                videoName = "How to use polymorphism with c#",
                videoTime = 600,
                Comments = new List<Comment>()
            };
            video3.Comments.Add(new Comment {commentAuthor = "PythonUser123", commentText = "This is very difficult stuff! Thanks for the video!"});
            video3.Comments.Add(new Comment {commentAuthor = "ProfStan2", commentText = "I am very impressed, learned a lot."});
            video3.Comments.Add(new Comment {commentAuthor = "ProgrammerGuy", commentText = "I'm still a beginner, but this was very informative and helpful."});
            
            videos.Add(video3);

            foreach (Video video in videos)
            {
                video.DisplayVideoInfo();
                
            }
            Console.ReadLine();
        }
    }
}