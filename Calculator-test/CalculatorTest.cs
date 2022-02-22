using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator_library;
using System;

namespace Calculator_test
{
    [TestClass]
    public class CalculatorTest
    {

        [TestMethod]
        [DataRow("5 1", 6)]
        [DataRow("10 20", 30)]
        [DataRow("30 22", 52)]
        [DataRow("1 20", 21)]
        public void Input_Add(string input, int expected)
        {
            Assert.AreEqual(expected, Library.Sum(input));
        }


        [TestMethod]
        [DataRow("5 1", 4)]
        [DataRow("15 5", 10)]
        [DataRow("30 22", 12)]
        [DataRow("10 2", 8)]
        public void Input_Sub(string input, int expected)
        {
            Assert.AreEqual(expected, Library.Sub(input));
        }


    }

}
