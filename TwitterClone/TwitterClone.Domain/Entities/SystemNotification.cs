using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class SystemNotification : Notification
    {
        public Guid SystemNotificationId { get; set; }

        public SystemNotification(Guid systemNotificationId) : base("System Notification")
        {
            SystemNotificationId = systemNotificationId;
        }

        public void AddMessage(string message)
        {
            Message = message;
        }
    }
}
