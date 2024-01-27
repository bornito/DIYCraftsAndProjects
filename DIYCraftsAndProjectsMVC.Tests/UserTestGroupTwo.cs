using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIYCraftsAndProjectsMVC.Tests
{
    public abstract class UserTestGroupTwo : UserTest, IUserMethodTest
    {
        public async Task UserMethodResultTest()
        {
            await Task.FromResult(0);
        }
    }
}
