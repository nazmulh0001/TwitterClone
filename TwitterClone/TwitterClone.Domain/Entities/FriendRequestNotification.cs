using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class FriendRequestNotification : Notification
    {
        public Guid RequestId { get; set; }

        public FriendRequestNotification(Guid requestId) : base("FriendRequest")
        {
            RequestId = requestId;
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, requested by user id: {UserId}"
        }

        public override string GetMessage()
        {
            return $"{UserId} sent you a friend request!";
        }
    }
}
