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
        public void single_word가_limit보다_작을때_줄바꿈하기()
        {
            string inputText = "test";
            string expectedText = "test";
            string actualText = "";
            int limit = 7;

            WordWrapper wordWrapper = new WordWrapper();

            actualText = wordWrapper.Wrap(inputText, limit);

            Assert.AreEqual(expectedText, actualText);
        }

        [TestMethod]
        public void single_word가_limit과_같을때_줄바꿈하기()
        {
            string inputText = "test";
            string expectedText = "test";
            string actualText = "";
            int limit = 4;

            WordWrapper wordWrapper = new WordWrapper();

            actualText = wordWrapper.Wrap(inputText, limit);

            Assert.AreEqual(expectedText, actualText);
        }

        [TestMethod]
        public void single_word가_limit보다_클때_줄바꿈하기()
        {
            string inputText = "test";
            string expectedText = "tes--t";
            string actualText = "";
            int limit = 3;

            WordWrapper wordWrapper = new WordWrapper();

            actualText = wordWrapper.Wrap(inputText, limit);

            Assert.AreEqual(expectedText, actualText);
        }

        [TestMethod]
        public void long_single_word가_limit보다_작을때_줄바꿈하기()
        {
            string inputText = "helloworld";
            string expectedText = "helloworld";
            string actualText = "";
            int limit = 20;

            WordWrapper wordWrapper = new WordWrapper();

            actualText = wordWrapper.Wrap(inputText, limit);

            Assert.AreEqual(expectedText, actualText);
        }

        [TestMethod]
        public void long_single_word가_limit보다_클때_줄바꿈하기()
        {
            string inputText = "areallylongword";
            string expectedText = "areall--ylongw--ord";
            string actualText = "";
            int limit = 6;

            WordWrapper wordWrapper = new WordWrapper();

            actualText = wordWrapper.Wrap(inputText, limit);

            Assert.AreEqual(expectedText, actualText);
        }

        [TestMethod]
        public void double_word가_limit보다_작을때_줄바꿈하기()
        {
            string inputText = "hello world";
            string expectedText = "hello world";
            string actualText = "";
            int limit = 20;

            WordWrapper wordWrapper = new WordWrapper();

            actualText = wordWrapper.Wrap(inputText, limit);

            Assert.AreEqual(expectedText, actualText);
        }

        [TestMethod]
        public void double_word가_limit보다_클때_줄바꿈하기()
        {
            string inputText = "hello world";
            string expectedText = "hello--world";
            string actualText = "";
            int limit = 7;

            WordWrapper wordWrapper = new WordWrapper();

            actualText = wordWrapper.Wrap(inputText, limit);

            Assert.AreEqual(expectedText, actualText);
        }
    }
}
