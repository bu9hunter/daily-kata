using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegularExpLibrary.Properties;

namespace RegularExpTest
{
    [TestClass]
    public class UnitTest1
    {
        RegularExpMatch regularExpMatch;

        [TestInitialize]
        public void TsetSetup()
        {
            regularExpMatch = new RegularExpMatch();
        }

        [TestMethod]
        public void MakeInstance()
        {
            RegularExpMatch regularExpMatch = new RegularExpMatch();
        }

        [TestMethod]
        public void firstMatchWithEmptyPattern()
        {
            bool result = regularExpMatch.isMatch("a", "");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void firstMatchWithDotPattern()
        {
            bool result = regularExpMatch.isMatch("a", ".");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void MatchWithStarPattern()
        {
            bool result = regularExpMatch.isMatch("aa", "a*");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void MatchWithDotStarPattern()
        {
            bool result = regularExpMatch.isMatch("ab", ".*");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void MatchWithCharStarPattern()
        {
            bool result = regularExpMatch.isMatch("aab", "c*a*b");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void MatchWithComplexDotStarPattern()
        {
            bool result = regularExpMatch.isMatch("mississippi", "mis*is*p*.");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void LeetCode_Example1()
        {
            bool result = regularExpMatch.isMatch("ab", ".*c");

            Assert.IsFalse(result);
        }
    }
}
