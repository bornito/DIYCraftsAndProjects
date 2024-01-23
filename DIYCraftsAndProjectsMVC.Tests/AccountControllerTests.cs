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

        //[Fact]
        //public void Login_ReturnsRedirectToActionResult_WhenUserExists()
        //{
        //    // Arrange
        //    var login = new Login { Email = "pero@mail.com", Password = "1234" };
        //    _mockContext.Object.Users.Add(new User { Email = login.Email, Password = login.Password });
        //    _mockContext.Object.SaveChanges();

        //    // Act
        //    var result = _controller.Login(login);

        //    // Assert
        //    var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
        //    Assert.Equal("Index", redirectToActionResult.ActionName);
        //    Assert.Equal("Post", redirectToActionResult.ControllerName);
        //}

        //[Fact]
        //public void Register_ReturnsRedirectToActionResult_WhenRegistrationIsSuccessful()
        //{
        //    // Arrange
        //    var account = new Account { Email = "pero@mail.com", Password = "1234" };

        //    // Act
        //    var result = _controller.Register(account);

        //    // Assert
        //    RedirectToActionResult? redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
        //    Assert.Equal("Login", redirectToActionResult.ActionName);
        //}
    }
}
