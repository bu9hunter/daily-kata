using System;
using MaximumDepthOfBinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MaximumDepthOfBinaryTreeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void makeInstance()
        {
            BinaryTreeManager binaryTreeManager = new BinaryTreeManager();
        }

        [TestMethod]
        public void MaximumDepth_BT_with_null()
        {
            TreeNode root = null;
            BinaryTreeManager binaryTreeManager = new BinaryTreeManager();

            Assert.AreEqual(0, binaryTreeManager.MaxDepth(root));
        }

        [TestMethod]
        public void MaximumDepth_BT_depth_1()
        {
            TreeNode root = new TreeNode(3);
            root.left = null;
            root.right = null;

            BinaryTreeManager binaryTreeManager = new BinaryTreeManager();

            Assert.AreEqual(1, binaryTreeManager.MaxDepth(root));
        }

        [TestMethod]
        public void MaximumDepth_BT_depth_2()
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(5);
            root.right = new TreeNode(7);
            root.left.left = null;
            root.left.right = null;
            root.right.left = null;
            root.right.right = null;

            BinaryTreeManager binaryTreeManager = new BinaryTreeManager();

            Assert.AreEqual(2, binaryTreeManager.MaxDepth(root));
        }

        [TestMethod]
        public void MaximumDepth_BT_depth_3()
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(5);
            root.right = new TreeNode(7);
            root.left.left = null;
            root.left.right = null;
            root.right.left = new TreeNode(10);
            root.right.right = new TreeNode(13);
            root.right.left.left = null;
            root.right.left.right = null;
            root.right.right.left = null;
            root.right.right.right = null;

            BinaryTreeManager binaryTreeManager = new BinaryTreeManager();

            Assert.AreEqual(3, binaryTreeManager.MaxDepth(root));
        }

        [TestMethod]
        public void MaximumDepth_BT_leetcode_failed_1()
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);
            root.right.left = null;
            root.right.right = null;
            root.left.left.left = null;
            root.left.left.right = null;
            root.left.right.left = null;
            root.left.right.right = null;

            BinaryTreeManager binaryTreeManager = new BinaryTreeManager();

            Assert.AreEqual(3, binaryTreeManager.MaxDepth(root));
        }
    }
}
