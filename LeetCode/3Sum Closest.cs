using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _3Sum_Closest
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            if (nums.Length < 3)
            {
                return 0;
            }
            int nowClose =nums[0] + nums[1]+nums[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    for (int k = j+1; k < nums.Length; k++)
                    {
                        Console.WriteLine("1." + nums[i] + " 2." + nums[j] + " 3." + nums[k]);
                        if (nowClose > Math.Abs(nums[i] + nums[j] + nums[k]-target))
                        {
                            nowClose = nums[i] + nums[j] + nums[k];
                        }
                    }
                }
            }

            return nowClose;
        }

        public int Vserion2(int[] nums, int target)
        {
            Array.Sort(nums);
            var result = nums[0] + nums[1] + nums[nums.Length - 1];
            for (int i = 0; i < nums.Length - 2; i++)
            {
                int start = i + 1, end = nums.Length - 1;
                while (start < end)
                {
                    int sum = nums[i] + nums[start] + nums[end];
                    if (sum > target)
                    {
                        end--;
                    }
                    else
                    {
                        start++;
                    }
                    if (Math.Abs(sum - target) < Math.Abs(result - target))
                    {
                        result = sum;
                    }
                }
            }
            return result;
        }
    }
}
