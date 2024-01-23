using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIYCraftsAndProjectsMVC.Tests
{
    public class ReportedTypeTests
    {
        [Fact]
        public void TestReportedTypeProperties()
        {
            // Arrange
            var mockReport = new Mock<Report>();
            var reports = new List<Report> { mockReport.Object };
            var reportedType = new ReportedType
            {
                ReportedTypeId = 1,
                Type = "Spam",
                Reports = reports
            };

            // Act
            var reportedTypeId = reportedType.ReportedTypeId;
            var type = reportedType.Type;
            var reportsList = reportedType.Reports;

            // Assert
            Assert.Equal(1, reportedTypeId);
            Assert.Equal("Spam", type);
            Assert.Equal(reports, reportsList);
        }
    }
}
