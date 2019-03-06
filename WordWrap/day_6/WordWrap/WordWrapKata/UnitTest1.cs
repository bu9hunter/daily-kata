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
        public void SubString테스트()
        {
            string testString = "test";
            string text = testString.Substring(0, 2);

            Assert.AreEqual("te", text);
        }

        [TestMethod]
        public void 한단어_길이가_줄바꿈_길이보다_작을때()
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
        public void 한단어_길이가_줄바꿈_길이보다_클때()
        {
            //given
            string inputString = "areallylongword";
            string expectedString = "areall--ylongw--ord";
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
        public void word_5줄바꿈하기()
        {
            //given
            string inputString = "word";
            string expectedString = "word";
            string wrappedString = "";
            WordWrapper wordWrapper = new WordWrapper();

            //when
            wrappedString = wordWrapper.Wrap(inputString, 5);

            //then
            Assert.AreEqual(expectedString, wrappedString);
        }

        [TestMethod]
        public void word_4줄바꿈하기()
        {
            //given
            string inputString = "word";
            string expectedString = "word";
            string wrappedString = "";
            WordWrapper wordWrapper = new WordWrapper();

            //when
            wrappedString = wordWrapper.Wrap(inputString, 4);

            //then
            Assert.AreEqual(expectedString, wrappedString);
        }

        [TestMethod]
        public void word_3줄바꿈하기()
        {
            //given
            string inputString = "word";
            string expectedString = "wor--d";
            string wrappedString = "";
            WordWrapper wordWrapper = new WordWrapper();

            //when
            wrappedString = wordWrapper.Wrap(inputString, 3);

            //then
            Assert.AreEqual(expectedString, wrappedString);
        }

        [TestMethod]
        public void word_word_4줄바꿈하기()
        {
            //given
            string inputString = "word word";
            string expectedString = "word--word";
            string wrappedString = "";
            WordWrapper wordWrapper = new WordWrapper();

            //when
            wrappedString = wordWrapper.Wrap(inputString, 4);

            //then
            Assert.AreEqual(expectedString, wrappedString);
        }

        [TestMethod]
        public void word_word_5줄바꿈하기()
        {
            //given
            string inputString = "word word";
            string expectedString = "word--word";
            string wrappedString = "";
            WordWrapper wordWrapper = new WordWrapper();

            //when
            wrappedString = wordWrapper.Wrap(inputString, 5);

            //then
            Assert.AreEqual(expectedString, wrappedString);
        }

        [TestMethod]
        public void word_word_6줄바꿈하기()
        {
            //given
            string inputString = "word word";
            string expectedString = "word--word";
            string wrappedString = "";
            WordWrapper wordWrapper = new WordWrapper();

            //when
            wrappedString = wordWrapper.Wrap(inputString, 6);

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

        //[TestMethod]
        //public void 긴단어_줄바꿈하기()
        //{
        //    //given
        //    string inputString = "a longword";
        //    string expectedString = "a long--word";
        //    string wrappedString = "";
        //    WordWrapper wordWrapper = new WordWrapper();

        //    //when
        //    wrappedString = wordWrapper.Wrap(inputString, 7);

        //    //then
        //    Assert.AreEqual(expectedString, wrappedString);
        //}
    }
}
