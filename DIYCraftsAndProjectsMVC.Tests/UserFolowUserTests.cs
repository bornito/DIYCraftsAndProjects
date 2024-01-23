using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIYCraftsAndProjectsMVC.Tests
{
    public class UserFolowUserTests
    {
            [Fact]
            public void TestUserFollowUserProperties()
            {
                // Arrange
                var mockUser = new Mock<User>();
                var userFollowUser = new UserFollowUser
                {
                    IdUserFollowUser = 1,
                    UserFollowingId = 2,
                    UserFollowedId = 3,
                    UserFollowed = mockUser.Object,
                    UserFollowing = mockUser.Object
                };

                // Act
                var idUserFollowUser = userFollowUser.IdUserFollowUser;
                var userFollowingId = userFollowUser.UserFollowingId;
                var userFollowedId = userFollowUser.UserFollowedId;
                var userFollowed = userFollowUser.UserFollowed;
                var userFollowing = userFollowUser.UserFollowing;

                // Assert
                Assert.Equal(1, idUserFollowUser);
                Assert.Equal(2, userFollowingId);
                Assert.Equal(3, userFollowedId);
                Assert.Equal(mockUser.Object, userFollowed);
                Assert.Equal(mockUser.Object, userFollowing);
            }
    }
}
