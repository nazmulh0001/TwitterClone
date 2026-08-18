using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class User : BaseEntity, IFollowable, INotifiable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        private List<Guid> _followers = new List<Guid>();
        private List<Guid> _incomingNotification = new List<Guid>();
        public User(string firstName, string lastName, string email) : base(Guid.NewGuid())
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }
        
        public void Follow(Guid userId)
        {
            if (!_followers.Contains(userId))
            {
                _followers.Add(userId);
            }
        }

        public void Unfollow(Guid userId)
        {
            if (_followers.Contains(userId))
            {
                _followers.Remove(userId);
            }
        }

        public void AddNotification(Guid notificationId)
        {
            if (!_incomingNotification.Contains(notificationId))
            {
                _incomingNotification.Add(notificationId);
            }
        }
    }
}
