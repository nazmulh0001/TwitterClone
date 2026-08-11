using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Tweet
    {
        public string Content { get; set; }
        public User Author { get; set; }

        public Tweet(string content, User author)
        {
            Content = content;
            Author = author;
        }
    }
}
