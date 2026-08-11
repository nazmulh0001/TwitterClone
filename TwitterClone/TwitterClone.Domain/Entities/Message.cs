using System;
using System.Collections.Generic;
using System.Text;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Domain
{
    public class Message
    {
        public User Sender { get; set; }
        public User Reciever { get; set; }
        public string Content { get; set; }

        public Message(User sender, User reciever, string message)
        {
            Sender = sender;
            Reciever = reciever;
            Content = message;
        }
    }
}
