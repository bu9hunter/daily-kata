using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegularExpressionLibrary;

namespace RegularExpressionTest
{
    [TestClass]
    public class RegularExpTest
    {
        [TestMethod]
        public void MakeInstance()
        {
            RegularExpression regExp = new RegularExpression();
        }

        [TestMethod]
        public void 맞는_단일문자_패턴찾기()
        {
            //given
            string text = "a";
            string pattern = "a";
            RegularExpression regExp = new RegularExpression();

            //when
            bool result = regExp.isMatch(text, pattern);

            //then
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void 맞지않는_단일문자_패턴찾기()
        {
            //given
            string text = "a";
            string pattern = "b";
            RegularExpression regExp = new RegularExpression();

            //when
            bool result = regExp.isMatch(text, pattern);

            //then
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Example1()
        {
            //given
            string text = "aa";
            string pattern = "a";
            RegularExpression regExp = new RegularExpression();

            //when
            bool result = regExp.isMatch(text, pattern);

            //then
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Example2()
        {
            //given
            string text = "aa";
            string pattern = "a*";
            RegularExpression regExp = new RegularExpression();

            //when
            bool result = regExp.isMatch(text, pattern);

            //then
            Assert.IsTrue(result);
        }
    }
}
