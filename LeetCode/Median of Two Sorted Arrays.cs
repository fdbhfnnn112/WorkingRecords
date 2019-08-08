using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Median_of_Two_Sorted_Arrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var index = nums1.Length + nums2.Length;
            var ListInt = nums1.ToList();
           ListInt.AddRange(nums2.ToList());
            ListInt.Sort();
            if (index % 2 == 0)
            {
                var indd = index / 2;
                return ((double)ListInt[index / 2] + (double)ListInt[(index / 2) -1]) / 2;
            }
            else
            {
                return (double)ListInt[index / 2];
            }
        }
    }
}
