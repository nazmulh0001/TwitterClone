using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Tweet : BaseEntity
    {
        public Guid UserId { get; set; }
        public string Content { get; set; }

        public Tweet(string content) : base(Guid.NewGuid())
        {
            Content = content;
        }
    }
}
