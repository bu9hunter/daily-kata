using System;

namespace Kth_Largest_Element
{
    public class Finder2
    {
        public Finder2()
        {
        }

        public int FindKthLargest(int[] nums, int k)
        {
            while (true)
            {
                int maxIndex = getMaxIndex(nums);
                k--;
                if (k == 0)
                {
                    return nums[maxIndex];
                }

                nums[maxIndex] = int.MinValue;
            }
        }

        public int getMaxIndex(int[] nums)
        {
            int maxValue = nums[0];
            int maxIndex = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > maxValue)
                {
                    maxValue = nums[i];
                    maxIndex = i;
                }
            }

            return maxIndex;
        }
    }
}