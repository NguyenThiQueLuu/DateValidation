using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class CheckMonth
    {
        [TestMethod]
        public void Test001()
        {
            Assert.IsTrue(Helper.CheckMonth("a") < 0);
        }

        [TestMethod]
        public void Test002()
        {
            Assert.IsTrue(Helper.CheckMonth("-1") < 0);
        }

        [TestMethod]
        public void Test003()
        {
            Assert.IsTrue(Helper.CheckMonth("1000") < 0);
        }

        [TestMethod]
        public void Test004()
        {
            Assert.IsTrue(Helper.CheckMonth("1") > 0);
        }
    }
}
