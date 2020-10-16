using StringBuilders.Entities;
using System;

namespace StringBuilders
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;

            while (repeat == true)
            {
                Console.Write("Insert a title of post: ");
                string title = Console.ReadLine();
                Console.Write("Insert a content of post: ");
                string content = Console.ReadLine();
                DateTime moment = DateTime.Now;
                Console.Write("Insert a number of likes: ");
                int likes = int.Parse(Console.ReadLine());

                Post post = new Post(moment, title, content);
                for (int i = 0; i < likes; i++)
                {
                    Console.WriteLine("Your post received a like!");
                    post.AddLike();
                }

                Console.WriteLine("Insert a number of comments: ");
                int ncomments = int.Parse(Console.ReadLine());
                Comment comment;
                for (int i = 0; i < ncomments; i++)
                {
                    Console.WriteLine("Insert text of comment: ");
                    string text = Console.ReadLine();
                    comment = new Comment(text, DateTime.Now);
                    post.AddComment(comment, DateTime.Now);
                }

                Console.WriteLine(post.ToString());

                Console.WriteLine("Do you want to do another post: (Y/N)");
                char r = char.Parse(Console.ReadLine().ToUpper());
                if (r == 'Y')
                {
                    repeat = true;
                }
                else
                {
                    repeat = false;
                }
            }
        }
    }
}
