using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordWrapper;

namespace WordWrap.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WordWrapper_인스턴스_만들기()
        {
            WordMachine wordMachine = new WordMachine();
        }

        [TestMethod]
        public void 한단어_줄바꿈하기()
        {
            string inputString = "test";
            string expectedString = "test";
            string actualString = "";

            WordMachine wordMachine = new WordMachine();

            actualString = wordMachine.wrap(inputString, 7);

            Assert.AreEqual(expectedString, actualString);
        }

        [TestMethod]
        public void 두단어_줄바꿈하기()
        {
            string inputString = "hello world";
            string expectedString = "hello--world";
            string actualString = "";

            WordMachine wordMachine = new WordMachine();

            actualString = wordMachine.wrap(inputString, 7);

            Assert.AreEqual(expectedString, actualString);
        }
    }
}
