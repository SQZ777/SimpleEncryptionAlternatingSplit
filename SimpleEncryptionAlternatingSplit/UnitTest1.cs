using System;
using System.Linq;
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
            EncryptResult("etTs", "Test", 1);
        }

        [TestMethod]
        public void Input_This_is_a_test驚嘆號And1_Should_Be_hsi_etTi_sats驚嘆號()
        {
            EncryptResult("hsi  etTi sats!", "This is a test!", 1);
        }

        [TestMethod]
        public void Input_This_is_a_test驚嘆號And2_Should_Be_hsi_etTi_sats驚嘆號()
        {
            EncryptResult("s eT ashi tist!", "This is a test!", 2);
        }

        [TestMethod]
        public void Input_This_is_a_test驚嘆號And3_Should_Be__Tah_itse_sits()
        {
            EncryptResult(" Tah itse sits!", "This is a test!", 3);
        }

        [TestMethod]
        public void Input_This_is_a_test驚嘆號And4_Should_Be_This_is_a_test驚嘆號()
        {
            EncryptResult("This is a test!", "This is a test!", 4);
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
            if (text.Equals(string.Empty) || times <= 0)
                return text;
            var result = getResult(text.ToArray()).Replace("\0", string.Empty);
            while (times > 1)
            {
                result = getResult(result.ToArray()).Replace("\0", string.Empty);
                times--;
            }
            return result;
        }
        private static string getResult(char[] textChar)
        {
            var secondCharsIndex = 0;
            var cutCharsIndex = 0;
            var secondCharsResult = new char[textChar.Length];
            var cutCutResult = new char[textChar.Length];
            for (int i = 0; i < textChar.Length; i++)
            {
                if (i % 2 == 1)
                {
                    secondCharsResult[secondCharsIndex] = textChar[i];
                    secondCharsIndex++;
                }
                else
                {
                    cutCutResult[cutCharsIndex] = textChar[i];
                    cutCharsIndex++;
                }
            }
            return string.Concat(new string(secondCharsResult), new string(cutCutResult));
        }
        public string Decrypt(string encryptedText, int n)
        {
            var result = string.Empty;
            return result;
        }
    }
}
