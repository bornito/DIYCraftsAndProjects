using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIYCraftsAndProjectsMVC.Tests
{
    public class UserTests : UserTestGroupOne
    {
        [Fact]
        public override void TestProperties()
        {
            // testiramo first name, last name i email

            // Arrange
            var userId = 1;
            var firstName = "Test";
            var lastName = "User";
            var email = "test@mail.com";

            // Act
            var user = new User
            {
                UserId = userId,
                FirstName = firstName,
                LastName = lastName,
                Email = email
            };

            // Assert
            Assert.Equal(userId, user.UserId);
            Assert.Equal(firstName, user.FirstName);
            Assert.Equal(lastName, user.LastName);
            Assert.Equal(email, user.Email);

            // datum rodjenja

            // Arrange
            var dateOfBirth = new DateTime(1990, 1, 1);

            // Act
            var user2 = new User
            {
                DateOfBirth = dateOfBirth
            };

            // Assert
            Assert.Equal(dateOfBirth, user2.DateOfBirth);

            // aktivnost

            // Arrange
            var isActive = true;

            // Act
            var user3 = new User
            {
                IsActive = isActive
            };

            // Assert
            Assert.Equal(isActive, user3.IsActive);

        }
    }
}
