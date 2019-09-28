using System;

namespace Stopwatch
{
    public class Post
    {
        public string Title;
        public string Description;
        private int TotalVotes;
        public DateTime Created;


        public void UpVote()
        {
            TotalVotes++;
        }

        public void DownVote()
        {
            TotalVotes--;
        }

        public void CurrentValue()
        {
            Console.WriteLine(TotalVotes);
        }

    }


    class MainClass
    {
        public static void Main(string[] args)
        {
            var post = new Post();

            post.Title = "Hello World";
            post.Description = "First program";
            post.Created = new DateTime(2019, 6, 22, 18, 47, 0);

            //Console.WriteLine(post.Created);
            post.UpVote();
            post.UpVote();
            post.DownVote();

            post.CurrentValue();
        }
    }
}
