using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kth_Largest_Element.Test
{
    /// <summary>
    /// Summary description for UnitTest2
    /// </summary>
    [TestClass]
    public class UnitTest2
    {
        public UnitTest2()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void makeInstance()
        {
            var finder2 = new Finder2();
        }

        [TestMethod]
        public void getMaxIndex()
        {
            int[] nums = new int[] { 3, 2, 1, 5, 6, 4 };

            var finder = new Finder2();

            Assert.AreEqual(4, finder.getMaxIndex(nums));
        }

        [TestMethod]
        public void findKthNumber()
        {
            int[] nums = new int[] { 3, 2, 1, 5, 6, 4 };
            int k = 1;
            int expectedLargestNumber = 6;

            var finder = new Finder2();

            Assert.AreEqual(expectedLargestNumber, finder.FindKthLargest(nums, k));
        }

        [TestMethod]
        public void findKthNumber2()
        {
            int[] nums = new int[] { 3, 2, 1, 5, 6, 4 };
            int k = 2;
            int expectedLargestNumber = 5;

            var finder = new Finder2();

            Assert.AreEqual(expectedLargestNumber, finder.FindKthLargest(nums, k));
        }

        [TestMethod]
        public void findKthNumber3()
        {
            int[] nums = new int[] { -1, -1 };
            int k = 2;
            int expectedLargestNumber = -1;

            var finder = new Finder2();

            Assert.AreEqual(expectedLargestNumber, finder.FindKthLargest(nums, k));
        }
    }
}
