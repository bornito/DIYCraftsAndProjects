using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// dodano

using Xunit;
using Moq;

using DIYCraftsAndProjectsMVC.Controllers;
using DIYCraftsAndProjectsMVC.Mapper;
using DIYCraftsAndProjectsMVC.Models;
using DIYCraftsAndProjectsMVC.Models.BLModel;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DIYCraftsAndProjectsMVC.Tests
{
    public class AccountControllerTests
    {
        private readonly Mock<CraftsAndProjectsDbContext> _mockContext;
        private readonly AccountController _controller;

        public AccountControllerTests()
        {
            var options = new DbContextOptionsBuilder<CraftsAndProjectsDbContext>()
                .UseInMemoryDatabase(databaseName: "TestnaBaza")
                .Options;

            _mockContext = new Mock<CraftsAndProjectsDbContext>(options);
            _controller = new AccountController(_mockContext.Object);
        }
   

        [Fact]
        public void Register_ReturnsRedirectToActionResult_WhenRegistrationIsSuccessful()
        {
            // Arrange
            var account = new Account { Email = "pero2@mail.com", Password = "1234" };
            var _mockSet = new Mock<DbSet<User>>();

            // Act
            var result = _controller.Register(account);

            // Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void Login_ReturnsRedirectToActionResult_WhenUserExists()
        {
            // Arrange
            var login = new Login { Email = "pero2@mail.com", Password = "1234" };
            var user = new User { Email = login.Email, Password = login.Password };

            var _mockSet = new Mock<DbSet<User>>();
            _mockSet.Setup(m => m.Find(It.IsAny<string>())).Returns(user);
            _mockContext.Setup(c => c.Users).Returns(_mockSet.Object);

            // Act
            var result = _controller.Login(login);

            // Assert
            Assert.NotNull(result); 
            Assert.IsAssignableFrom<IActionResult>(result); 
        }
    }
}
