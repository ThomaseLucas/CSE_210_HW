using System.Collections.Generic;
namespace Foundation1
{
    public class Video
    {
        public int videoTime;
        public string videoName;
        public string videoAuthor;
        public List<Comment> Comments = new List<Comment>();


        public int NumberComments()
        {
            return Comments.Count();
        }

        public void DisplayVideoInfo()
        {
            Console.WriteLine("Title: " + videoName);
            Console.WriteLine("Author: " + videoAuthor);
            Console.WriteLine("Length: " + videoTime + " seconds");
            Console.WriteLine("Number of Comments: " + NumberComments());
            Console.WriteLine("Comments:");
            foreach (Comment comment in Comments)
                {
                    Console.WriteLine("Commenter: " + comment.commentAuthor);
                    Console.WriteLine("Text: " + comment.commentText);
                    Console.WriteLine();
                }
                Console.WriteLine();
        }

    }
}