using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIYCraftsAndProjectsMVC.Tests
{
    public class WelcomeControllerTests
    {
        [Fact]
        public void TestIndexAction()
        {
            // Arrange
            var mockLogger = new Mock<ILogger<WelcomeController>>();
            var controller = new WelcomeController(mockLogger.Object);

            // Act
            var result = controller.Index();

            // Assert
            Assert.IsType<ViewResult>(result);
        }

        //[Fact]
        //public void TestErrorAction()
        //{
        //    // Arrange
        //    var mockLogger = new Mock<ILogger<WelcomeController>>();
        //    var controller = new WelcomeController(mockLogger.Object);

        //    // Act
        //    var result = controller.Error();

        //    // Assert
        //    var viewResult = Assert.IsType<ViewResult>(result);
        //    var model = Assert.IsAssignableFrom<ErrorViewModel>(viewResult.ViewData.Model);
        //    Assert.NotNull(model.RequestId);
        //}
    }
}
