using System;
using MBT_Test;
using System.Linq;

namespace MBT_Solution
{
    public class MBT
    {
        public TreeNode construct(int[] nums, int l, int r)
        {
            if (l == r)
                return null;

            //int max_i = nums.ToList().IndexOf(nums.Max());
            int max_i = max(nums, l, r);

            TreeNode root = new TreeNode(nums[max_i]);
            root.left = construct(nums, l, r);

            return root;
        }

        public int max(int[] nums, int l, int r)
        {
            int max_i = l;
            for (int i = l; i < r; i++)
            {
                if (nums[max_i] < nums[i])
                {
                    max_i = i;
                }
            }
            return max_i;
        }
    }
}