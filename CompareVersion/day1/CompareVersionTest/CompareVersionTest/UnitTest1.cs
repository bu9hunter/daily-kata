using System;
using CompareVersionLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CompareVersionTest
{
    [TestClass]
    public class UnitTest1
    {
        CompareVersionClass cv;

        [TestInitialize]
        public void Setup()
        {
            cv = new CompareVersionClass();
        }

        [TestMethod]
        public void MakeInstance()
        {
            CompareVersionClass cv = new CompareVersionClass();
        }

        [TestMethod]
        public void CompareVersionWith2LevelRev()
        {
            string version1 = "0.1";
            string version2 = "1.1";
            int result = 0;

            result = cv.CompareVersion(version1, version2);

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void CompareVersionWithFirstMatch()
        {
            string version1 = "1.0.1";
            string version2 = "1";
            int result = 0;

            result = cv.CompareVersion(version1, version2);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void CompareVersionWithThridMatch()
        {
            string version1 = "7.5.2.4";
            string version2 = "7.5.3";
            int result = 0;

            result = cv.CompareVersion(version1, version2);

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void CompareVersionWithZero()
        {
            string version1 = "1.01";
            string version2 = "1.001";
            int result = 0;

            result = cv.CompareVersion(version1, version2);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CompareVersionWithZeroZero()
        {
            string version1 = "1.0";
            string version2 = "1.0.0";
            int result = 0;

            result = cv.CompareVersion(version1, version2);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Leetcode_Fail_Case1()
        {
            string version1 = "0.9.9.9.9.9.9.9.9.9.9.9.9";
            string version2 = "1.0";
            int result = 0;

            result = cv.CompareVersion(version1, version2);

            Assert.AreEqual(-1, result);
        }
    }
}
