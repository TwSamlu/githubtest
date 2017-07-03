using Microsoft.VisualStudio.TestTools.UnitTesting;
using GitHubTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubTest.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTestAreNotEqual()
        {
            Assert.AreNotEqual(1, 2);
        }

        [TestMethod()]
        public void AddTestIsTrue()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void AddTestIsFalse()
        {
            Assert.IsFalse(false);
        }
    }


}