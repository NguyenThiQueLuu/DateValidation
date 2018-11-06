using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DateTime;

namespace Test
{
    [TestClass]
    public class CheckDays
    {
        [TestMethod]
        public void Test001()
        {
            Assert.IsTrue(Helper.CheckDays("a") < 0);
        }

        [TestMethod]
        public void Test002()
        {
            Assert.IsTrue(Helper.CheckDays("-1") < 0);
        }

        [TestMethod]
        public void Test003()
        {
            Assert.IsTrue(Helper.CheckDays("1000") < 0);
        }

        [TestMethod]
        public void Test004()
        {
            Assert.IsTrue(Helper.CheckDays("1") > 0);
        }
    }
}
