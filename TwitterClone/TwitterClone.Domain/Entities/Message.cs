using System;
using System.Collections.Generic;
using System.Text;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Domain
{
    public class Message : BaseEntity
    {
        public Guid SenderId { get; set; }
        public Guid ReceiverId { get; set; }
        public string Content { get; set; }
        public bool IsRead { get; set; }

        public Message(Guid senderId, Guid receiverId, string content, bool isRead) : base(Guid.NewGuid())
        {
            SenderId = senderId;
            ReceiverId = receiverId;
            Content = content;
            IsRead = isRead;
        }

    }
}
