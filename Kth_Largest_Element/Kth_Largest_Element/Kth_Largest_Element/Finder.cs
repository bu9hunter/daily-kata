using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Kth_Largest_Element
{
    public class Finder
    {
        public Finder()
        {
        }

        public int[] DoSort(int[] unsorted)
        {
            List<int> list = unsorted.ToList();

            list.Sort();
            list.Reverse();

            return list.ToArray();
        }

        public int FindKthLargest(int[] nums, int k)
        {
            int[] sortedArray = DoSort(nums);

            return sortedArray[k - 1];
        }
    }
}