using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIYCraftsAndProjectsMVC.Tests
{
    public class UploadedFileTests
    {
        [Fact]
        public void TestUploadedFileProperties()
        {
            // Arrange
            var mockPost = new Mock<Post>();
            var uploadedFile = new UploadedFile
            {
                IdUploadedFile = 1,
                FileName = "test.txt",
                FileType = "text/plain",
                FileContent = new byte[] { 0x74, 0x65, 0x73, 0x74 }, // ASCII for "test"
                PostId = 2,
                Post = mockPost.Object
            };

            // Act
            var idUploadedFile = uploadedFile.IdUploadedFile;
            var fileName = uploadedFile.FileName;
            var fileType = uploadedFile.FileType;
            var fileContent = uploadedFile.FileContent;
            var postId = uploadedFile.PostId;
            var post = uploadedFile.Post;

            // Assert
            Assert.Equal(1, idUploadedFile);
            Assert.Equal("test.txt", fileName);
            Assert.Equal("text/plain", fileType);
            Assert.Equal(new byte[] { 0x74, 0x65, 0x73, 0x74 }, fileContent);
            Assert.Equal(2, postId);
            Assert.Equal(mockPost.Object, post);
        }
    }
}
