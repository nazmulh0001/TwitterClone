using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    class Program
    {
        static void Main()
        {
            User nazmul = new User("Nazmul");
            User john = new User("John");

            nazmul.PostTweet("Hello Twitter!");

            nazmul.Follow(john);

            nazmul.SendMessage(john, "Hi John!");
        }
    }
}
