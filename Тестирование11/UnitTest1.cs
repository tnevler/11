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
            char[] a = { '0', '1', '1', '1', '0', '0', '0', '1' };
            string result1 = "00110110";
            string result2 = "01110001";
            char[] b = Program.Coding(a);
            char[] c = Program.Transcription(b);
            string b1 = string.Concat(b);
            string c1 = string.Concat(c);
            Assert.AreEqual(result1, b1);
            Assert.AreEqual(result2, c1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            char[] a = { '.', '-', '-', '-', '.', '.', '.', '-' };
            string result1 = "..--.--.";
            string result2 = ".---...-";
            char[] b = Program.Coding(a);
            char[] c = Program.Transcription(b);
            string b1 = string.Concat(b);
            string c1 = string.Concat(c);
            Assert.AreEqual(result1, b1);
            Assert.AreEqual(result2, c1);
        }
    }
}
