using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordWrapper;

namespace WordWrap.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WordWrapper_인스턴스만들기()
        {
            WordTools wordTools = new WordTools();
        }

        [TestMethod]
        public void 한단어_줄바꿈하기()
        {
            string inputText = "test";
            string expectedText = "test";
            string actualText = "";

            WordTools wordTools = new WordTools();

            actualText = wordTools.wrap(inputText, 7);

            Assert.AreEqual(expectedText, actualText);
        }

        [TestMethod]
        public void 한단어_줄바꿈하기_2()
        {
            string inputText = "helloworld";
            string expectedText = "helloworld";
            string actualText = "";

            WordTools wordTools = new WordTools();

            actualText = wordTools.wrap(inputText, 7);

            Assert.AreEqual(expectedText, actualText);
        }

        //[TestMethod]
        //public void 두단어_줄바꿈하기()
        //{
        //    string inputText = "hello world";
        //    string expectedText = "hello--world";
        //    string actualText = "";

        //    WordTools wordTools = new WordTools();

        //    actualText = wordTools.wrap(inputText, 7);

        //    Assert.AreEqual(expectedText, actualText);
        //}

        //[TestMethod]
        //public void 문장_줄바꿈하기()
        //{
        //    string inputText = "a lot of words for a single line";
        //    string expectedText = "a lot of--words for--a single--line";
        //    string actualText = "";

        //    WordTools wordTools = new WordTools();

        //    actualText = wordTools.wrap(inputText, 10);

        //    Assert.AreEqual(expectedText, actualText);
        //}
    }
}
