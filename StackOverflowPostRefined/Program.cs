using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// https://drive.google.com/open?id=106X9o_Y0jR80vw50RZpiph24LKRRY0JV&authuser=arzej2k%40gmail.com&usp=drive_fs
// Exercise 2: Design a StackOverflow Post
namespace StackOverflowPost
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; protected set; }
        private int VoteCounter { get; set; }
        public int GetCounter()
        {
            return VoteCounter;
        }
        public Post(string postTitle, string postDesc)
        {
            Title = postTitle;
            Description = postDesc;
            CreatedAt = DateTime.Now;
        }
        public void UpVote()
        {
            VoteCounter++;
        }
        public void DownVote()
        {
            VoteCounter--;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Post post = new("post 1", "opis");
            while (true)
            {
                var command = Console.ReadLine();

                switch (command)
                {
                    case "d":
                        post.DownVote();
                        break;
                    case "u":
                        post.UpVote();
                        break;
                    case "print":
                        Console.WriteLine(post.GetCounter());
                        break;

                }
            }
        }
    }
}