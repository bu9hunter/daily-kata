using System;

namespace MaximumDepthOfBinaryTree
{
    public class BinaryTreeManager
    {
        public BinaryTreeManager()
        {
        }

        public int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;

            int leftMaxDepthCount = 1 + MaxDepth(root.left);
            int rightMaxDepthCount = 1 + MaxDepth(root.right);

            return Math.Max(leftMaxDepthCount, rightMaxDepthCount);
        }

        //public int leftMaxDepthCount = 0;
        //public int rightMaxDepthCount = 0;

        //public int MaxDepth(TreeNode root)
        //{
        //    if (root == null) return 0;

        //    visit(root);
            
        //    return (leftMaxDepthCount >= rightMaxDepthCount ? leftMaxDepthCount : rightMaxDepthCount) + 1;
        //}

        //private void visit(TreeNode root)
        //{
        //    if (root == null)
        //        return;

        //    if (root.left != null)
        //    {
        //        visit(root.left);
        //        leftMaxDepthCount++;
        //    }

        //    if (root.right != null)
        //    {
        //        visit(root.right);
        //        rightMaxDepthCount++;
        //    }
        //}
    }
}