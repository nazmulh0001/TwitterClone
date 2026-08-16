using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Like : BaseEntity
    {
        public Guid Userid { get; set; }
        public Guid TweetId { get; set; }


        public Like() : base(Guid.NewGuid())
        {

        }
    }
}
