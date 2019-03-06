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
        public void 한단어_줄바꿈하기()
        {
            string inputText = "test";
            string expectedText = "test";
            string actualText = "";
            int limit = 7;

            WordWrapper wordWrapper = new WordWrapper();

            actualText = wordWrapper.wrap(inputText, limit);

            Assert.AreEqual(expectedText, actualText);
        }

        [TestMethod]
        public void 두단어_줄바꿈하기()
        {
            string inputText = "hello world";
            string expectedText = "hello--world";
            string actualText = "";
            int limit = 7;

            WordWrapper wordWrapper = new WordWrapper();

            actualText = wordWrapper.wrap(inputText, limit);

            Assert.AreEqual(expectedText, actualText);
        }

        [TestMethod]
        public void 한줄에_많은단어_줄바꿈하기()
        {
            string inputText = "a lot of words for a single line";
            string expectedText = "a lot of--words for--a single--line";
            string actualText = "";
            int limit = 10;

            WordWrapper wordWrapper = new WordWrapper();

            actualText = wordWrapper.wrap(inputText, limit);

            Assert.AreEqual(expectedText, actualText);
        }

        [TestMethod]
        public void 테스트문장_줄바꿈하기()
        {
            string inputText = "this is a test";
            string expectedText = "this--is a--test";
            string actualText = "";
            int limit = 4;

            WordWrapper wordWrapper = new WordWrapper();

            actualText = wordWrapper.wrap(inputText, limit);

            Assert.AreEqual(expectedText, actualText);
        }
    }
}
