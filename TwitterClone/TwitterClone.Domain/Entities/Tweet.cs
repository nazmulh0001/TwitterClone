using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Tweet : BaseEntity, ILikeable
    {
        public Guid UserId { get; set; }
        public string Content { get; set; }

        public Tweet(string content) : base(Guid.NewGuid())
        {
            Content = content;
        }

        public Tweet(Guid userId, string content) : base(Guid.NewGuid())
        {
            UserId = userId;
            Content = content;
        }

        public void AddContent(string content)
        {
            Content = content;
        }

        public void AddContent(Guid userId, string content)
        {
            UserId = userId;
            Content = content;
        }

        public bool CanBeLiked()
        {
            if (string.IsNullOrWhiteSpace(Content))
            {
                return false;
            }
            return true;
        }
    }
}
