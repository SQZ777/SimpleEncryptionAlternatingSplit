using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleEncryptionAlternatingSplit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input_NullAnd0_Should_Be_Null()
        {
            var kata = new Kata();
            var text = string.Empty;
            int times = 0;
            var actual =  kata.Encrypt(text, times);
            var expected = string.Empty;
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void Input_123And0_Should_Be_123()
        {
            var kata = new Kata();
            var text = "123";
            int times = 0;
            var actual = kata.Encrypt(text, times);
            var expected = "123";
            Assert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public string Encrypt(string text, int times)
        {
            return text;
        }
    }
}
