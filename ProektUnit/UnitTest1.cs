using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace ProektUnit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddition()
        {
            int result = Calculator.Add(2, 3);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestSubtraction()
        {
            int result = Calculator.Subtract(5, 2);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestMultiplication()
        {
            int result = Calculator.Multiply(4, 3);
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void TestDivision()
        {
            int result = Calculator.Divide(10, 2);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestModulo()
        {
            int result = Calculator.Modulo(15, 10);
            Assert.AreEqual(5, result);
        }
    }
}
