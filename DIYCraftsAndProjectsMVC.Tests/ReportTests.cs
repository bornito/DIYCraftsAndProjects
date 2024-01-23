using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIYCraftsAndProjectsMVC.Tests
{
    public class ReportTests
    {
        [Fact]
        public void TestReportProperties()
        {
            // Arrange
            var mockUser = new Mock<User>();
            var mockReportedType = new Mock<ReportedType>();
            var report = new Report
            {
                ReportId = 1,
                ReportedId = 2,
                ReportingId = 3,
                Description = "Test report",
                ReportedTypeId = 4,
                Sent = DateTime.Now,
                Resolved = false,
                Reported = mockUser.Object,
                ReportedType = mockReportedType.Object,
                Reporting = mockUser.Object
            };

            // Act
            var reportId = report.ReportId;
            var reportedId = report.ReportedId;
            var reportingId = report.ReportingId;
            var description = report.Description;
            var reportedTypeId = report.ReportedTypeId;
            var sent = report.Sent;
            var resolved = report.Resolved;
            var reported = report.Reported;
            var reportedType = report.ReportedType;
            var reporting = report.Reporting;

            // Assert
            Assert.Equal(1, reportId);
            Assert.Equal(2, reportedId);
            Assert.Equal(3, reportingId);
            Assert.Equal("Test report", description);
            Assert.Equal(4, reportedTypeId);
            Assert.NotNull(sent);
            Assert.False(resolved.Value);
            Assert.Equal(mockUser.Object, reported);
            Assert.Equal(mockReportedType.Object, reportedType);
            Assert.Equal(mockUser.Object, reporting);
        }
    }
}
