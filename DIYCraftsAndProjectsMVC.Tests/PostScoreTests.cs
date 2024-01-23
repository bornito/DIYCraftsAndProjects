using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIYCraftsAndProjectsMVC.Tests
{
    public class PostScoreTests
    {
        [Fact]
        public void TestPostScoreProperties()
        {
            // Arrange
            var mockPost = new Mock<Post>();
            var mockUser = new Mock<User>();
            var postScore = new PostScore
            {
                PostScoreId = 1,
                PostId = 2,
                UserId = 3,
                Score = 10,
                Post = mockPost.Object,
                User = mockUser.Object
            };

            // Act
            var postScoreId = postScore.PostScoreId;
            var postId = postScore.PostId;
            var userId = postScore.UserId;
            var score = postScore.Score;
            var post = postScore.Post;
            var user = postScore.User;

            // Assert
            Assert.Equal(1, postScoreId);
            Assert.Equal(2, postId);
            Assert.Equal(3, userId);
            Assert.Equal(10, score);
            Assert.Equal(mockPost.Object, post);
            Assert.Equal(mockUser.Object, user);
        }
    }
}
