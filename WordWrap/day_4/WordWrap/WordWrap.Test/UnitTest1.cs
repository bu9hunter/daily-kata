using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordWrap.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        public void WordWrapper_인스턴스_만들기()
        {
            WordWrapper wordWrapper = new WordWrapper();
        }

        [TestMethod]
        public void WordWrapper_test_문자열입력()
        {
            WordWrapper wordWrapper = new WordWrapper();

            string wrappedString = wordWrapper.wrap("test", 7);

            Assert.AreEqual("test", wrappedString);
        }

        [TestMethod]
        public void WordWrapper_hello_world_문자열입력()
        {
            WordWrapper wordWrapper = new WordWrapper();

            string wrappedString = wordWrapper.wrap("hello world", 7);

            Assert.AreEqual("hello--world", wrappedString);
        }
    }
}
