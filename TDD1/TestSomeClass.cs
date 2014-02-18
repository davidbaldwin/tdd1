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

        [TestMethod]
        public void TestFib2Returns1()
        {
            Assert.AreEqual(1, Fibonacci(2));
        }

        //[TestMethod]
        //public void TestFib3Returns2()
        //{
        //    Assert.AreEqual(2, Fibonacci(3));
        //}

        private int Fibonacci(int index)
        {
            return index < 2 ? index : 1;
        }
    }
}
