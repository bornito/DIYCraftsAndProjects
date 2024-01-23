using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIYCraftsAndProjectsMVC.Tests
{
    public class CommentTests
    {
        [Fact]
        public void TestCommentProperties()
        {
            // Arrange
            var comment = new Comment
            {
                CommentId = 1,
                PostId = 1,
                Comment1 = "Test Comment",
                ParentId = null,
                UserId = 1,
                Posted = DateTime.Now,
                Highlighted = false,
                Reported = false,
                InverseParent = new List<Comment>(),
                Parent = null,
                Post = new Post(),
                User = new User()
            };

            // Act -> nemamo action, samo testiramo postavljanje vrijednosti

            // Assert
            Assert.Equal(1, comment.CommentId);
            Assert.Equal(1, comment.PostId);
            Assert.Equal("Test Comment", comment.Comment1);
            Assert.Null(comment.ParentId);
            Assert.Equal(1, comment.UserId);
            Assert.NotNull(comment.Posted);
            Assert.False(comment.Highlighted);
            Assert.False(comment.Reported);
            Assert.Empty(comment.InverseParent);
            Assert.Null(comment.Parent);
            Assert.NotNull(comment.Post);
            Assert.NotNull(comment.User);
        }
    }
}
