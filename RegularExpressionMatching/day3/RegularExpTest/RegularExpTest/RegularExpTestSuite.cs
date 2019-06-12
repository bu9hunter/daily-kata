using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegularExpLibrary;

namespace RegularExpTest
{
    [TestClass]
    public class RegularExpTestSuite
    {
        RegularExpression regExp;

        [TestInitialize]
        public void testInit()
        {
            regExp = new RegularExpression();
        }

        [TestMethod]
        public void _0_MakeInstance()
        {
            RegularExpression regExp = new RegularExpression();
        }

        [TestMethod]
        public void _1_글자패턴1개_매칭확인하기()
        {
            //given
            string text = "a";
            string pattern = "a";

            //when
            bool result = regExp.isMatch(text, pattern);

            //then
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void _2_글자패턴2개_매칭확인하기()
        {
            //given
            string text = "aa";
            string pattern = "aa";

            //when
            bool result = regExp.isMatch(text, pattern);

            //then
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void _3_글자패턴3개_매칭확인하기()
        {
            //given
            string text = "abc";
            string pattern = "abc";

            //when
            bool result = regExp.isMatch(text, pattern);

            //then
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void _4_Example1()
        {
            //given
            string text = "aa";
            string pattern = "a";

            //when
            bool result = regExp.isMatch(text, pattern);

            //then
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void _5_와일드카드패턴1개_매칭확인하기()
        {
            //given
            string text = "a";
            string pattern = ".";

            //when
            bool result = regExp.isMatch(text, pattern);

            //then
            Assert.IsTrue(result);
        }
    }
}
