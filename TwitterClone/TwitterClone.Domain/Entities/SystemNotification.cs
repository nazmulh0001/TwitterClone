using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class SystemNotification : Notification
    {
        public Guid SystemNotificationId { get; set; }

        public SystemNotification(Guid systemNotificationId) : base("System")
        {
            SystemNotificationId = systemNotificationId;
        }

        public void AddMessage(string message)
        {
            Message = message;
        }

        public override string DescribeRecord()
        {
            return $"Notification type: {NotificationType}; Comment user id: {UserId}; Comment message: {Message}";
        }

        public override string GetMessage()
        {
            return "System Notification: Unknown Error";
        }
    }
}
