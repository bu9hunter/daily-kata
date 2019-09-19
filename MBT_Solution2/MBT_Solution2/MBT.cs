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
                int[] leftArray = inputArray.Take(getMaxIndex(inputArray)).ToArray();

                if (leftArray.Length != 0)
                {
                    node.left = ConstructMaximumBinaryTree(leftArray);
                }

                int[] rightArray = inputArray.Skip(getMaxIndex(inputArray) + 1).ToArray();

                if (rightArray.Length != 0)
                {
                    node.right = ConstructMaximumBinaryTree(rightArray);
                }          
            }

            return node;
        }
    }
}