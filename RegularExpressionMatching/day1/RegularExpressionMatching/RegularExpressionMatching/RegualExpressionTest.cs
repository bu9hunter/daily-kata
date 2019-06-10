using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegularExpressionLibrary;

namespace RegularExpressionMatching
{
    [TestClass]
    public class RegualExpressionTest
    {
        [TestMethod]
        public void MakeInstance()
        {
            RegualExpression RegualExp = new RegualExpression();
        }

        [TestMethod]
        public void 문자1개_패턴_찾지못할경우_False리턴하기하기_2()
        {
            //given
            RegualExpression regularExp = new RegualExpression();
            string inputString = "b";
            string pattern = "a";

            //when
            bool result = regularExp.isMatch(inputString, pattern);

            //then
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void 문자1개_패턴_찾을경우_True리턴하기()
        {
            //given
            RegualExpression regularExp = new RegualExpression();
            string inputString = "a";
            string pattern = "a";

            //when
            bool result = regularExp.isMatch(inputString, pattern);

            //then
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void 문자1개_패턴_찾지못할경우_False리턴하기하기_1()
        {
            //given
            RegualExpression regularExp = new RegualExpression();
            string inputString = "aa";
            string pattern = "a";

            //when
            bool result = regularExp.isMatch(inputString, pattern);

            //then
            Assert.IsFalse(result);
        }
    }
}
