using System;
using MBT_Solution;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MBT_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void makeInstance()
        {
            MBT mbt = new MBT();
        }

        [TestMethod]
        public void getMaxIndex()
        {
            int[] inputArray = new int[] { 1, 2, 5, 3, 4 };

            MBT mbt = new MBT();
           
            int maxIndex = mbt.max(inputArray, 0, inputArray.Length);

            Assert.AreEqual(2, maxIndex);
        }
 
        [TestMethod]
        public void oneArray()
        {
            int[] inputArray = new int[] { 5 };

            MBT mbt = new MBT();
            TreeNode node = new TreeNode();
            TreeNode expectedNode = new TreeNode(5);

            node = mbt.construct(inputArray, 0, 1);

            Assert.AreEqual(expectedNode.val, node.val);
        }

        [TestMethod]
        public void twoArray()
        {
            int[] inputArray = new int[] { 3, 5 };

            MBT mbt = new MBT();
            TreeNode node = new TreeNode();
            TreeNode expectedNode = new TreeNode(5);
            expectedNode.left = new TreeNode(3);

            node = mbt.construct(inputArray, 0, 2);

            Assert.AreEqual(expectedNode.val, node.val);
            Assert.AreEqual(expectedNode.left.val, node.left.val);
        }
    }
}
