using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kth_Largest_Element.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MakeInstance()
        {
            Finder finder = new Finder();
        }

        [TestMethod]
        public void UnsortedArrayToSortedArray()
        {
            int[] unsorted = new int[] { 3, 2, 1, 5, 6, 4 };
            int[] sorted = new int[] { 6, 5, 4, 3, 2, 1 };

            Finder finder = new Finder();

            CollectionAssert.AreEqual(sorted, finder.DoSort(unsorted));
        }

        [TestMethod]
        public void UnsortedArrayToSortedArray_2()
        {
            int[] unsorted = new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 };
            int[] sorted = new int[] { 6, 5, 5, 4, 3, 3, 2, 2, 1 };

            Finder finder = new Finder();

            CollectionAssert.AreEqual(sorted, finder.DoSort(unsorted));
        }

        [TestMethod]
        public void FindKthLargestElement_Leetcode_Ex1()
        {
            int[] unsorted = new int[] { 3, 2, 1, 5, 6, 4 };
            int findLargestPosition = 2;
            int expectedLargestNumber = 5;

            Finder finder = new Finder();

            Assert.AreEqual(expectedLargestNumber, finder.FindKthLargest(unsorted, findLargestPosition));
        }

    }
}
