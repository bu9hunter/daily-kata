using System;
using MBT_Solution2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MBT_Solution.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void makeInstance()
        {
            var mbt = new MBT();
        }

        [TestMethod]
        public void makeTreeNode()
        {
            var treeNode = new TreeNode(0);
        }

        [TestMethod]
        public void insertNode()
        {
            var treeNode = new TreeNode(5);

            Assert.AreEqual(5, treeNode.val);
        }

        [TestMethod]
        public void getMaxIndex()
        {
            int[] inputArray = new int[] { 3, 1, 5, 4, 2 };
            var mbt = new MBT();

            int maxIndex = mbt.getMaxIndex(inputArray);

            Assert.AreEqual(2, maxIndex);
        }

        [TestMethod]
        public void setRootNode()
        {
            int[] inputArray = new int[] { 5 };
            var mbt = new MBT();
            var rootTreeNode = mbt.ConstructMaximumBinaryTree(inputArray);

            Assert.AreEqual(5, rootTreeNode.val);
        }

        [TestMethod]
        public void leftRootNode()
        {
            int[] inputArray = new int[] { 1, 5 };
            var mbt = new MBT();
            var rootTreeNode = mbt.ConstructMaximumBinaryTree(inputArray);

            Assert.AreEqual(5, rootTreeNode.val);
            Assert.AreEqual(1, rootTreeNode.left.val);
            Assert.IsNull(rootTreeNode.right);
        }

        [TestMethod]
        public void rightRootNode()
        {
            int[] inputArray = new int[] { 5, 3 };
            var mbt = new MBT();
            var rootTreeNode = mbt.ConstructMaximumBinaryTree(inputArray);

            Assert.AreEqual(5, rootTreeNode.val);
            Assert.IsNull(rootTreeNode.left);
            Assert.AreEqual(3, rootTreeNode.right.val);
        }

        //[TestMethod]
        //public void leftRootNode2()
        //{
        //    int[] inputArray = new int[] { 1, 3, 5 };
        //    var mbt = new MBT();
        //    var rootTreeNode = mbt.ConstructMaximumBinaryTree(inputArray);

        //    Assert.AreEqual(5, rootTreeNode.val);
        //    Assert.AreEqual(1, rootTreeNode.left.val);
        //    Assert.IsNull(rootTreeNode.right);
        //}

        [TestMethod]
        public void leftandrightRootNode()
        {
            int[] inputArray = new int[] { 1, 5, 3 };
            var mbt = new MBT();
            var rootTreeNode = mbt.ConstructMaximumBinaryTree(inputArray);

            Assert.AreEqual(5, rootTreeNode.val);
            Assert.AreEqual(1, rootTreeNode.left.val);
            Assert.AreEqual(3, rootTreeNode.right.val);
        }

        //[TestMethod]
        //public void leftandrightRootNode2()
        //{
        //    int[] inputArray = new int[] { 1, 2, 5, 3, 6 };
        //    var mbt = new MBT();
        //    var rootTreeNode = mbt.ConstructMaximumBinaryTree(inputArray);

        //    Assert.AreEqual(5, rootTreeNode.val);
        //    Assert.AreEqual(1, rootTreeNode.left.val);
        //    Assert.AreEqual(3, rootTreeNode.right.val);
        //}
    }
}
