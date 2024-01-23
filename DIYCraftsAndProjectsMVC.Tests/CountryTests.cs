using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIYCraftsAndProjectsMVC.Tests
{
    public class CountryTests
    {
        // postavljanje za državu

        [Fact]
        public void TestCountryProperties()
        {
            // Arrange
            var country = new Country
            {
                CountryId = 1,
                CountryName = "Test Country",
                Users = new List<User>()
            };

            // Act -> nemamo action, samo testiramo postavljanje vrijednosti

            // Assert
            Assert.Equal(1, country.CountryId);
            Assert.Equal("Test Country", country.CountryName);
            Assert.Empty(country.Users);
        }
    }
}
