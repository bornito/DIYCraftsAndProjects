﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIYCraftsAndProjectsMVC.Tests
{
    public abstract class UserMethodTest : IUserMethodTest
    {
        public abstract Task UserMethodResultTest();
    }
}
