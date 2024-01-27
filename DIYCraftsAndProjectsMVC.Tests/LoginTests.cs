using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIYCraftsAndProjectsMVC.Tests
{
    public class LoginTests
    {
        [Fact]
        public void Login_EmailAndPassword_Required()
        {
            var login = new Login();

            var context = new ValidationContext(login, null, null);
            var results = new List<ValidationResult>();

            // Act
            var isModelStateValid = Validator.TryValidateObject(login, context, results, true);

            // Assert
            Assert.False(isModelStateValid);
            Assert.Equal(2, results.Count);
        }
    }
}
