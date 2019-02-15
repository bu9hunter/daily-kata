using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordWrap;

namespace WordWrapKata
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WordWrap_인스턴스_만들기()
        {
            WordWrapper wordWrapper = new WordWrapper();
        }

        [TestMethod]
        public void 한단어_줄바꿈하기()
        {
            //given
            string inputString = "test";
            string expectedString = "test";
            string wrappedString = "";
            WordWrapper wordWrapper = new WordWrapper();

            //when
            wrappedString = wordWrapper.Wrap(inputString, 7);

            //then
            Assert.AreEqual(expectedString, wrappedString);
        }

        [TestMethod]
        public void 두단어_줄바꿈하기()
        {
            //given
            string inputString = "hello world";
            string expectedString = "hello--world";
            string wrappedString = "";
            WordWrapper wordWrapper = new WordWrapper();

            //when
            wrappedString = wordWrapper.Wrap(inputString, 7);

            //then
            Assert.AreEqual(expectedString, wrappedString);
        }

        [TestMethod]
        public void 문장_줄바꿈하기()
        {
            //given
            string inputString = "a lot of words for a single line";
            string expectedString = "a lot of--words for--a single--line";
            string wrappedString = "";
            WordWrapper wordWrapper = new WordWrapper();

            //when
            wrappedString = wordWrapper.Wrap(inputString, 10);

            //then
            Assert.AreEqual(expectedString, wrappedString);
        }
    }
}
