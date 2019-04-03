using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Samples.Tests
{
    [TestClass]
    public class CezarCipherTests
    {
        [TestMethod]
        public void Extended_cezar_cipher_work_on_A_to_z()
        {
            //Given
            var testValue = "A";
            var delay = 51;
            //When
            var result = CezarCipher.CezarCipher.Extended(testValue.ToString(), delay);
            //Then           
            Assert.AreEqual("z", result);
        }

        [TestMethod]
        public void Extended_cezar_cipher_work_on_B_to_A()
        {
            //Given
            var testValue = "B";
            var delay = 51;
            //When
            var result = CezarCipher.CezarCipher.Extended(testValue.ToString(), delay);
            //Then           
            Assert.AreEqual("A", result);
        }

        [TestMethod]
        public void Extended_cezar_cipher_work_on_A_to_a()
        {
            //Given
            var testValue = "A";
            var delay = 26;
            //When
            var result = CezarCipher.CezarCipher.Extended(testValue.ToString(), delay);
            //Then           
            Assert.AreEqual("a", result);
        }

        [TestMethod]
        public void Extended_cezar_cipher_work_on_Z_to_z()
        {
            //Given
            var testValue = "Z";
            var delay = 26;
            //When
            var result = CezarCipher.CezarCipher.Extended(testValue.ToString(), delay);
            //Then           
            Assert.AreEqual("z", result);
        }
    }
}
