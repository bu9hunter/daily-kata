using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using WordWrap;

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
        public void WordWrap_인스턴스_만들기()
        {
            WordWrapper wordWrapper = new WordWrapper();
        }
    }
}
