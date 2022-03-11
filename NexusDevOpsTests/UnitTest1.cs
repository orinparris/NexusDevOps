using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace NexusDevOpsTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var a = 5;
            var b = 6;
            var c = a+b;
            Assert.IsTrue(c==11);
        }
    }
}
