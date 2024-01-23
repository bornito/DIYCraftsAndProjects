using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIYCraftsAndProjectsMVC.Tests
{
    public class PostTests
    {
        // testiramo post, comment, postscore i user model

        [Fact]
        public void TestPostProperties()
        {
            // Arrange
            var post = new Post
            {
                PostId = 1,
                UserId = 1,
                Public = true,
                DatePosted = DateTime.Now,
                DateDeleted = null,
                Views = 0,
                Score = 0,
                Title = "Test Title",
                FileType = "txt",
                Content =  "Test",
                Comments = new List<Comment>(),
                PostScores = new List<PostScore>(),
                User = new User()
            };

            // Act -> nemamo action, samo testiramo postavljanje vrijednosti
         

            // Assert
            Assert.Equal(1, post.PostId);
            Assert.Equal(1, post.UserId);
            Assert.True(post.Public);
            Assert.NotNull(post.DatePosted);
            Assert.Null(post.DateDeleted);
            Assert.Equal(0, post.Views);
            Assert.Equal(0, post.Score);
            Assert.Equal("Test Title", post.Title);
            Assert.Equal("txt", post.FileType);
            Assert.Equal("Test", post.Content);
            Assert.Empty(post.Comments);
            Assert.Empty(post.PostScores);
            Assert.NotNull(post.User);
        }
    }
}
