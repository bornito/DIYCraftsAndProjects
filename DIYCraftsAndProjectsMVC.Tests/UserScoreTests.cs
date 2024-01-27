using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIYCraftsAndProjectsMVC.Tests
{
    public class UserScoreTests : IUserTest
    {
        [Fact]
        public void TestProperties()
        {
            // Arrange
            var mockUser = new Mock<User>();
            var userScore = new UserScore
            {
                UserScoreId = 1,
                UserId = 2,
                UserIdScorer = 3,
                Score = 10,
                User = mockUser.Object,
                UserIdScorerNavigation = mockUser.Object
            };

            // Act
            var userScoreId = userScore.UserScoreId;
            var userId = userScore.UserId;
            var userIdScorer = userScore.UserIdScorer;
            var score = userScore.Score;
            var user = userScore.User;
            var userIdScorerNavigation = userScore.UserIdScorerNavigation;

            // Assert
            Assert.Equal(1, userScoreId);
            Assert.Equal(2, userId);
            Assert.Equal(3, userIdScorer);
            Assert.Equal(10, score);
            Assert.Equal(mockUser.Object, user);
            Assert.Equal(mockUser.Object, userIdScorerNavigation);
        }
    }
}
