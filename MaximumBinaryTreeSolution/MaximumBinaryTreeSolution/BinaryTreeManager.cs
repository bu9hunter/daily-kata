using System;
using System.Linq;

namespace MaximumBinaryTreeSolution
{
    public class BinaryTreeManager
    {
        public BinaryTreeManager()
        {
        }

        public int getIndexOfMaxValue(int[] tree)
        {
            return tree.ToList().IndexOf(tree.Max());
        }

        public void splitTreeByMaxValue(int[] mainTree, int maxIndex, int[] leftTree, int[] rightTree)
        {
            throw new NotImplementedException();
        }
    }
}