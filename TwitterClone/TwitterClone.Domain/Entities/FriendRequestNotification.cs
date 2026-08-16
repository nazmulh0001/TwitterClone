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

        public void AddMessage(string message)
        {
            Message = message;
        }
    }
}
