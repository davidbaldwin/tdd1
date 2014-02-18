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

        [TestMethod]
        public void TestFib3Returns2()
        {
            Assert.AreEqual(2, Fibonacci(3));
        }

        [TestMethod]
        public void TestFib12Returns144()
        {
            Assert.AreEqual(144, Fibonacci(12));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),"Fibonacci is undefined for negative numbers.")]
        public void TestFibNegativeReturnsError()
        {
            int result = Fibonacci(-1);
        }

        private int Fibonacci(int index)
        {
            return index < 2 ? index : Fibonacci(index - 1) + Fibonacci(index - 2);
        }
    }
}
