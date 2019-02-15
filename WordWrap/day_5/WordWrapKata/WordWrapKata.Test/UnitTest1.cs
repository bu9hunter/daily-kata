using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordWrap;

namespace WordWrapKata.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WordWrap_인스턴스_만들기()
        {
            WordWrapTool wordWrapTool = new WordWrapTool();
        }

        [TestMethod]
        public void test_문자열_줄바꿈하기()
        {
            WordWrapTool wordWrapTool = new WordWrapTool();

            string wrappedText = wordWrapTool.Wrap("test", 7);

            Assert.AreEqual("test", wrappedText);
        }

        [TestMethod]
        public void 두단어_줄바꿈하기()
        {
            WordWrapTool wordWrapTool = new WordWrapTool();

            string wrappedText = wordWrapTool.Wrap("hello world", 7);

            Assert.AreEqual("hello--world", wrappedText);
        }

        [TestMethod]
        public void 많은단어_줄바꿈하기()
        {
            WordWrapTool wordWrapTool = new WordWrapTool();

            string wrappedText = wordWrapTool.Wrap("a lot of words for a single line", 10);

            Assert.AreEqual("a lot of--words for--a single--line", wrappedText);
        }
    }
}
