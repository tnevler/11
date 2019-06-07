using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Практика11;

namespace Тестирование11
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string a = "01110001";
            string result = "00110110";
            char[] b = Program.Coding(a);
            string b1 = string.Concat(b);
            Assert.AreEqual(result, b1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string a = ".---...-";
            string result = "..--.--.";
            char[] b = Program.Coding(a);
            string b1 = string.Concat(b);
            Assert.AreEqual(result, b1);
        }
    }
}
