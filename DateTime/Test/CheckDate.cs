﻿using System;
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
    }
}
