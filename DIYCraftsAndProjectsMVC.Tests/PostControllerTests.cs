using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIYCraftsAndProjectsMVC.Tests
{
    public class PostControllerTests
    {

        // details kada za id dobije null

        [Fact]
        public async Task Details_ReturnsNotFoundResult_WhenIdIsNull()
        {
            // Arrange
            var mockContext = new Mock<CraftsAndProjectsDbContext>();
            var controller = new PostsController(mockContext.Object);

            // Act
            var result = await controller.Details(null);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }

        // create metoda

        [Fact]
        public async Task Create_ReturnsRedirectToActionResult_WhenModelStateIsValid()
        {
            // Arrange
            var mockContext = new Mock<CraftsAndProjectsDbContext>();
            var controller = new PostsController(mockContext.Object);
            var post = new Post();

            // Act
            var result = await controller.Create(post);

            // Assert
            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Index", redirectToActionResult.ActionName);
        }

        // edit metoda

        [Fact]
        public async Task Edit_ReturnsNotFoundResult_WhenIdDoesNotMatchPostId()
        {
            // Arrange
            var mockContext = new Mock<CraftsAndProjectsDbContext>();
            var controller = new PostsController(mockContext.Object);
            var post = new Post { PostId = 1 };

            // Act
            var result = await controller.Edit(2, post);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }

    }
}
