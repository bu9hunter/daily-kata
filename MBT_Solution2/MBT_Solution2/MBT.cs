using System;
using System.Linq;

namespace MBT_Solution2
{
    public class MBT
    {
        public MBT()
        {
        }

        public int getMaxIndex(int[] inputArray)
        {
            return inputArray.ToList().IndexOf(inputArray.Max());
        }

        public TreeNode ConstructMaximumBinaryTree(int[] inputArray)
        {
            TreeNode node = new TreeNode(inputArray.Max());

            if (inputArray.Length > 1)
            {
                if (getMaxIndex(inputArray) < (inputArray.Length - 1))
                {
                    node.right = new TreeNode(inputArray[getMaxIndex(inputArray) + 1]);
                }

                if (getMaxIndex(inputArray) > 0)
                {
                    node.left = new TreeNode(inputArray[getMaxIndex(inputArray) - 1]);   
                }            
            }

            return node;
        }
    }
}