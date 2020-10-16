using System;
namespace StringBuilders.Entities
{
    class Comment
    {
        public string Text { get; set; }
        public DateTime TimeStamp { get; set; }

        public Comment()
        {
        }

        public Comment(string text, DateTime timeStamp)
        {
            Text = text;
            TimeStamp = timeStamp;
        }
    }
}
