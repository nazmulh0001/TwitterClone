using TwitterClone.Domain.Entities;

Console.WriteLine("Hello, World!");

var likeNotification = new CommentNotification(Guid.NewGuid());

Console.WriteLine(likeNotification.DescribeRecord());