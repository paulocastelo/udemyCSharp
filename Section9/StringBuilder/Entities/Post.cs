using System;
using System.Text;
using System.Collections.Generic;

namespace StringBuilders.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; private set; }
        public List<Comment> Comments { get; private set; } = new List<Comment>();

        public Post()
        {
        }

        public Post(DateTime moment, string title, string content)
        {
            Moment = moment;
            Title = title;
            Content = content;
        }

        public void AddLike()
        {
            Likes++;
        }
        public void RemoveLike()
        {
            Likes--;
        }

        public void AddComment(Comment comment, DateTime date)
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.AppendLine(Content);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Comments:");
            foreach(Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }
    }
}
