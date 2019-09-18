using System;
using System.Linq;

namespace MaximumBinaryTreeSolution
{
    public class BinaryTreeManager
    {
        public BinaryTreeManager()
        {
        }

        public int getIndexOfMaxValue(int[] data)
        {
            return data.ToList().IndexOf(data.Max());
        }

        public void splitTreeByMaxValue(int[] mainTree, int maxIndex, int[] leftTree, int[] rightTree)
        {
            throw new NotImplementedException();
        }

        public TreeNode ConstructMaximumBinaryTree(int[] dataArray)
        {
            int maxIndex = getIndexOfMaxValue(dataArray);

            TreeNode treeNode = new TreeNode(dataArray[maxIndex]);


            

            return treeNode;
        }
    }
}