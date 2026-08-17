using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Bookmark : BaseEntity
    {
        public Guid UserId { get; set; }
        public Guid TweetId { get; set; }
        public Bookmark(Guid id, Guid tweetId) : base(Guid.NewGuid())
        {
            UserId = id;
            TweetId = tweetId;
        }
    }
}
