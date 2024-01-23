using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIYCraftsAndProjectsMVC.Tests
{
    public class UserTests
    {
        // testiramo first name, last name i email
        [Fact]
        public void User_CreatesNewUser_SetsPropertiesCorrectly()
        {
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
        }

        // datum rodjenja

        [Fact]
        public void User_CreatesNewUser_SetsDateOfBirthCorrectly()
        {
            // Arrange
            var dateOfBirth = new DateTime(1990, 1, 1);

            // Act
            var user = new User
            {
                DateOfBirth = dateOfBirth
            };

            // Assert
            Assert.Equal(dateOfBirth, user.DateOfBirth);
        }

        // aktivnost

        [Fact]
        public void User_CreatesNewUser_SetsIsActiveCorrectly()
        {
            // Arrange
            var isActive = true;

            // Act
            var user = new User
            {
                IsActive = isActive
            };

            // Assert
            Assert.Equal(isActive, user.IsActive);
        }
    }
}
