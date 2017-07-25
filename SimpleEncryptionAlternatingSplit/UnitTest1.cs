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
            EncryptResult(string.Empty, string.Empty, 0);
        }

        [TestMethod]
        public void Input_123And0_Should_Be_123()
        {
            EncryptResult("123", "123", 0);
        }

        [TestMethod]
        public void Input_NullAnd1_Should_Be_Null()
        {
            EncryptResult(string.Empty, string.Empty, 1);
        }

        [TestMethod]
        public void Input_Test_And1_Should_Be_eTst()
        {
            EncryptResult("eTst", "Test", 1);
        }

        private static void EncryptResult(string expected, string text, int times)
        {
            var kata = new Kata();
            var actual = kata.Encrypt(text, times);
            Assert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public string Encrypt(string text, int times)
        {
            return text;
        }

        public string Decrypt(string encryptedText, int n)
        {
            var result = string.Empty;
            return result;
        }
    }
}
