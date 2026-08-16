using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class CommentNotification : Notification
    {
        public Guid CommentUserId { get; set; }

        public CommentNotification(Guid commentUserId) : base("Comment")
        {
            CommentUserId = commentUserId;
        }

        public void AddMessage(string message)
        {
            Message = message;
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord} -> Comment user id: {CommentUserId}; Comment message: {Message}";
        }

        public override string GetMessage()
        {
            return $"{UserId} commented on your tweet!";
        }
    }
}
