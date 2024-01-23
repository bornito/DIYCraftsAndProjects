using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIYCraftsAndProjectsMVC.Tests
{
    public class ErrorViewModelTests
    {
        [Fact]
        public void TestErrorViewModelProperties()
        {
            // Arrange
            var errorViewModel = new ErrorViewModel
            {
                RequestId = "1234"
            };

            // Act
            var requestId = errorViewModel.RequestId;
            var showRequestId = errorViewModel.ShowRequestId;

            // Assert
            Assert.Equal("1234", requestId);
            Assert.True(showRequestId);
        }
    }    
}
