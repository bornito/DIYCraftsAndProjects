using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIYCraftsAndProjectsMVC.Tests
{
    public class AccountTests
    {
        private Account _account;

        public AccountTests()
        {
            _account = new Account
            {
                FirstName = "Test",
                LastName = "User",
                DateOfBirth = new DateTime(1990, 1, 1),
                Email = "test.user@example.com",
                UserName = "testuser",
                CountryId = 1,
                TypeId = 1,
                DateCreated = DateTime.Now,
                IsActive = true,
                Password = "password123"
            };
        }

        [Fact]
        public void TestFirstName()
        {
            Assert.Equal("Test", _account.FirstName);
        }

        [Fact]
        public void TestLastName()
        {
            Assert.Equal("User", _account.LastName);
        }

    }
}
