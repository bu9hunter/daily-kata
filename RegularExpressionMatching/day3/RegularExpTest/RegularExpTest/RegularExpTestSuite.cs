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
        public void _00_MakeInstance()
        {
            RegularExpression regExp = new RegularExpression();
        }

        [TestMethod]
        public void _01_글자패턴1개_매칭확인하기()
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
        public void _02_글자패턴2개_매칭확인하기()
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
        public void _03_글자패턴3개_매칭확인하기()
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
        public void _04_Example1()
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
        public void _05_Dot패턴1개_매칭확인하기()
        {
            //given
            string text = "a";
            string pattern = ".";

            //when
            bool result = regExp.isMatch(text, pattern);

            //then
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void _06_Dot패턴1개_매칭확인하기2()
        {
            //given
            string text = "b";
            string pattern = ".";

            //when
            bool result = regExp.isMatch(text, pattern);

            //then
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void _07_Dot패턴2개_매칭확인하기()
        {
            //given
            string text = "bc";
            string pattern = "..";

            //when
            bool result = regExp.isMatch(text, pattern);

            //then
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void _08_글자패턴1개_Dot패턴1개_매칭확인하기()
        {
            //given
            string text = "bc";
            string pattern = "b.";

            //when
            bool result = regExp.isMatch(text, pattern);

            //then
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void _09_Dot패턴1개_글자패턴1개_매칭확인하기()
        {
            //given
            string text = "bc";
            string pattern = ".c";

            //when
            bool result = regExp.isMatch(text, pattern);

            //then
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void _10_글자패턴1개_Asterisk패턴1개_매칭확인하기()
        {
            //given
            string text = "aa";
            string pattern = "a*";

            //when
            bool result = regExp.isMatch(text, pattern);

            //then
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void _11_글자패턴1개_Asterisk패턴1개_매칭확인하기()
        {
            //given
            string text = "aaa";
            string pattern = "a*";

            //when
            bool result = regExp.isMatch(text, pattern);

            //then
            Assert.IsTrue(result);
        }
    }
}
