using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class LikeNotification : Notification
    {
        public Guid LikeByUserId { get; set; }
        public LikeNotification(Guid likeByUserId) : base("Like")
        {
            LikeByUserId = likeByUserId;
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, liked by {UserId}";
        }

        public override string GetMessage()
        {
            return $"{UserId} liked your tweet!";
        }
    }
}
