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

        [TestMethod]
        public void Test003()
        {
            Assert.IsTrue(Helper.IsValidDate("30", "100", "2000") == false);
        }
        public void Test004()
        {
            Assert.IsTrue(Helper.IsValidDate("300", "100", "2000") == false);
        }
        public void Test005()
        {
            Assert.IsTrue(Helper.IsValidDate("27", "a", "2000") == false);
        }
        public void Test006()
        {
            Assert.IsTrue(Helper.IsValidDate("56", "1", "2000") == false);
        }
        public void Test007()
        {
            Assert.IsTrue(Helper.IsValidDate("3", "1", "2000") == true);
        }
        public void Test008()
        {
            Assert.IsTrue(Helper.IsValidDate("3", "100", "2000") == false);
        }
        public void Test009()
        {
            Assert.IsTrue(Helper.IsValidDate("500", "10", "2000") == false);
        }
        public void Test0010()
        {
            Assert.IsTrue(Helper.IsValidDate("0", "10", "2000") == false);
        }
        public void Test011()
        {
            Assert.IsTrue(Helper.IsValidDate("a", "10", "2000") == false);
        }
    }
}
