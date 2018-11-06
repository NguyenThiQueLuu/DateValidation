using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class CheckDate
    {
        [TestMethod]
        public void Test001()
        {
            Assert.IsTrue(Helper.IsValidDate("1","1","2000") == true);
        }

        [TestMethod]
        public void Test002()
        {
            Assert.IsTrue(Helper.IsValidDate("30", "2", "2000") == false);
        }
    }
}
