using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordWrap.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void 인스턴스_만들기()
        {
            WordWrapper wordWrapper = new WordWrapper();
        }

        [TestMethod]
        public void 한단어_기준7_줄바꿈하기()
        {
            string inputText = "test";
            string expectedText = "test";
            string actualText = "";

            WordWrapper wordWrapper = new WordWrapper();

            actualText = wordWrapper.wrap(inputText, 7);

            Assert.AreEqual(expectedText, actualText);
        }

        [TestMethod]
        public void 한단어_기준3_줄바꿈하기()
        {
            string inputText = "test";
            string expectedText = "test";
            string actualText = "";

            WordWrapper wordWrapper = new WordWrapper();

            actualText = wordWrapper.wrap(inputText, 3);

            Assert.AreEqual(expectedText, actualText);
        }

        //[TestMethod]
        //public void 두단어_기준7_줄바꿈하기()
        //{
        //    string inputText = "hello world";
        //    string expectedText = "hello--world";
        //    string actualText = "";

        //    WordWrapper wordWrapper = new WordWrapper();

        //    actualText = wordWrapper.wrap(inputText, 7);

        //    Assert.AreEqual(expectedText, actualText);
        //}
    }
}
