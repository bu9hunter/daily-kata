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
        public void makeTreeNode()
        {
            TreeNode treeNode = new TreeNode(5);

            Assert.AreEqual(5, treeNode.val);
        }

        [TestMethod]
        public void makeLeftTreeNode()
        {
            TreeNode treeNode = new TreeNode(5);
            TreeNode leftNode = new TreeNode(3);

            treeNode.left = leftNode;

            Assert.AreEqual(3, treeNode.left.val);
        }

        [TestMethod]
        public void makeRightTreeNode()
        {
            TreeNode treeNode = new TreeNode(5);
            TreeNode rightNode = new TreeNode(1);

            treeNode.right = rightNode;

            Assert.AreEqual(1, treeNode.right.val);
        }

        [TestMethod]
        public void oneTreeNode()
        {
            int[] dataArray = new int[] { 5 };

            BinaryTreeManager btm = new BinaryTreeManager();
            TreeNode rootNode = btm.ConstructMaximumBinaryTree(dataArray);

            Assert.AreEqual(5, rootNode.val);
        }

        [TestMethod]
        public void twoTreeNode()
        {
            int[] dataArray = new int[] { 5, 3 };

            BinaryTreeManager btm = new BinaryTreeManager();
            TreeNode rootNode = btm.ConstructMaximumBinaryTree(dataArray);

            Assert.AreEqual(5, rootNode.val);
            Assert.AreEqual(3, rootNode.right.val);
        }

        [TestMethod]
        public void findMaxIntegerIndex()
        {
            int[] mainTree = new int[] { 3, 2, 1, 6, 0, 5 };

            BinaryTreeManager btm = new BinaryTreeManager();

            int maxIndex = btm.getIndexOfMaxValue(mainTree);

            Assert.AreEqual(3, maxIndex);
        }

        //[TestMethod]
        //public void splitArrayByMaxInteger()
        //{
        //    int[] mainTree = new int[] { 3, 2, 1, 6, 0, 5 };
        //    int[] expectedLeftTree = new int[] { 3, 2, 1 };
        //    int[] expectedRightTree = new int[] { 0, 5 };
        //    int[] leftTree = new int[100];
        //    int[] rightTree = new int[100];

        //    BinaryTreeManager btm = new BinaryTreeManager();

        //    int maxIndex = btm.getIndexOfMaxValue(mainTree);

        //    btm.splitTreeByMaxValue(mainTree, maxIndex, leftTree, rightTree);

        //    CollectionAssert.AreEqual(expectedLeftTree, leftTree);
        //    CollectionAssert.AreEqual(expectedRightTree, rightTree);
        //}
    }
}
