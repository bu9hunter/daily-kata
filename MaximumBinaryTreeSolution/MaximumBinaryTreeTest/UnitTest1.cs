using System;
using MaximumBinaryTreeSolution;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MaximumBinaryTreeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MakeInstance()
        {
            BinaryTreeManager btm = new BinaryTreeManager();
        }

        [TestMethod]
        public void findMaxIntegerIndex()
        {
            int[] mainTree = new int[] { 3, 2, 1, 6, 0, 5 };

            BinaryTreeManager btm = new BinaryTreeManager();

            int maxIndex = btm.getIndexOfMaxValue(mainTree);

            Assert.AreEqual(3, maxIndex);
        }

        [TestMethod]
        public void splitArrayByMaxInteger()
        {
            int[] mainTree = new int[] { 3, 2, 1, 6, 0, 5 };
            int[] expectedLeftTree = new int[] { 3, 2, 1 };
            int[] expectedRightTree = new int[] { 0, 5 };
            int[] leftTree = new int[100];
            int[] rightTree = new int[100];

            BinaryTreeManager btm = new BinaryTreeManager();

            int maxIndex = btm.getIndexOfMaxValue(mainTree);

            btm.splitTreeByMaxValue(mainTree, maxIndex, leftTree, rightTree);

            CollectionAssert.AreEqual(expectedLeftTree, leftTree);
            CollectionAssert.AreEqual(expectedRightTree, rightTree);
        }
    }
}
