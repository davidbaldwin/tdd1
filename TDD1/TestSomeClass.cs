using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD1
{
    [TestClass]
    public class TestSomeClass
    {
        [TestMethod]
        public void TestFib0Returns0()
        {
            Assert.AreEqual(0, Fibonacci(0));
        }

        [TestMethod]
        public void TestFib1Returns1()
        {
            Assert.AreEqual(1, Fibonacci(1));
        }

        private object Fibonacci(object index)
        {
            return 0;
        }
    }
}
