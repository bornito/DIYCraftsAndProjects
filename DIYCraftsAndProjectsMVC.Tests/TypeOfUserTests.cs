using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIYCraftsAndProjectsMVC.Tests
{
    public class TypeOfUserTests
    {
        [Fact]
        public void TestTypeOfUserProperties()
        {
            // Arrange
            var mockUser = new Mock<User>();
            var users = new List<User> { mockUser.Object };
            var typeOfUser = new TypeOfUser
            {
                TypeId = 1,
                TypeName = "Admin",
                Users = users
            };

            // Act
            var typeId = typeOfUser.TypeId;
            var typeName = typeOfUser.TypeName;
            var usersList = typeOfUser.Users;

            // Assert
            Assert.Equal(1, typeId);
            Assert.Equal("Admin", typeName);
            Assert.Equal(users, usersList);
        }
    }
}
