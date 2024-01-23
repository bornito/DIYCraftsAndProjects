using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIYCraftsAndProjectsMVC.Tests
{
    public class UserControllerTests
    {
        // Testovi za Edit metode->

        // kada je id null
        [Fact]
        public async Task Details_ReturnsNotFoundResult_WhenIdIsNull()
        {
            // Arrange
            var mockContext = new Mock<CraftsAndProjectsDbContext>();
            var controller = new UsersController(mockContext.Object);

            // Act
            var result = await controller.Details(null);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }

        // kada nema id-a
        [Fact]
        public async Task Edit_ReturnsNotFoundResult_WhenIdDoesNotExist()
        {
            // Arrange
            var mockContext = new Mock<CraftsAndProjectsDbContext>();
            var controller = new UsersController(mockContext.Object);
            int testId = 1; // Assuming this id does not exist in the database

            // Act
            var result = await controller.Edit(testId);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }

        // post metoda

        [Fact]
        public async Task Edit_RedirectsToIndexView_AfterSuccessfulUpdate()
        {
            // Arrange
            var mockContext = new Mock<CraftsAndProjectsDbContext>();
            var controller = new UsersController(mockContext.Object);
            var user = new User { UserId = 1, FirstName = "Test", LastName = "User", Email = "test@mail.com" };

            // Act
            var result = await controller.Edit(user.UserId, user);

            // Assert
            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Index", redirectToActionResult.ActionName);
        }


        // Testovi za Create metode->

        // nakon uspjesnog stvaranja
        [Fact]
        public async Task Create_RedirectsToIndexView_AfterSuccessfulCreation()
        {
            // Arrange
            var mockContext = new Mock<CraftsAndProjectsDbContext>();
            var controller = new UsersController(mockContext.Object);
            var user = new User { UserId = 1, FirstName = "Test", LastName = "User", Email = "test@mail.com" };

            // Act
            var result = await controller.Create(user);

            // Assert
            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Index", redirectToActionResult.ActionName);
        }

        // vraca li index metoda viewresult

        //[Fact]
        //public async Task Index_ReturnsViewResult()
        //{
        //    // Arrange
        //    var mockContext = new Mock<CraftsAndProjectsDbContext>();
        //    var controller = new UsersController(mockContext.Object);

        //    // Act
        //    var result = await controller.Index();

        //    // Assert
        //    Assert.IsType<ViewResult>(result);
        //}


    }
}
