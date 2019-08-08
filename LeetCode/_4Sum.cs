using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _4Sum
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            IList<IList<int>> res = new List<IList<int>>();
            Array.Sort(nums);
            int First = 0;
            
            int Last = nums.Length;
            for (int i = 0; i < nums.Length - 3; i++)
            {
                int FirstStep = First + 1;
                int LastStep = Last - 2;
                GetNum(nums, target, res, First, Last, FirstStep, LastStep);
                if (Math.Abs(nums[First]) > nums[Last-1])
                {
                    First++;
                }
                else
                {
                    Last--;
                }
            }

            return res;
        }

        private static void GetNum(int[] nums, int target, IList<IList<int>> res, int First, int Last, int FirstStep, int LastStep)
        {
            if (nums[First] + nums[FirstStep] + nums[LastStep] + nums[Last - 1] == target)
            {
                var set = new int[] { nums[First], nums[FirstStep], nums[LastStep], nums[Last - 1] }.ToList();
                if (res.Count == 0)
                {
                    res.Add(set);
                }
                var copy = res.Count;

                for(int i = 0;i<copy;i++)
                
                {
                    if (!(res[i][0] == set[0] && res[i][1] == set[1] && res[i][2] == set[2] && res[i][3] == set[3]) || res.Count == 0 )
                    {
                        res.Add(set);
                    }
                }
                

            }

            if (FirstStep == LastStep)
            {
                return;
            }

            if (Math.Abs(nums[FirstStep]) > Math.Abs(nums[LastStep]))
            {
                FirstStep++;
            }
            else
            {
                LastStep--;
            }

            GetNum(nums, target, res, First, Last, FirstStep, LastStep);
        }


        public IList<IList<int>> fourSum(int[] nums, int target)
        {
            IList<IList<int>> res = new List<IList<int>>();
            int len = nums.Length;
            if (nums == null || len < 4)
                return res;

            Array.Sort(nums);

            int max = nums[len - 1];
            if (4 * nums[0] > target || 4 * max < target)
                return res;

            int i, z;
            for (i = 0; i < len; i++)
            {
                z = nums[i];
                if (i > 0 && z == nums[i - 1])// avoid duplicate
                    continue;
                if (z + 3 * max < target) // z is too small
                    continue;
                if (4 * z > target) // z is too large
                    break;
                if (4 * z == target)
                { // z is the boundary
                    if (i + 3 < len && nums[i + 3] == z)
                        res.Add(new List<int>() { z,z,z,z});
                    break;
                }

                threeSumForFourSum(nums, target - z, i + 1, len - 1, res, z);
            }

            return res;
        }

        public void threeSumForFourSum(int[] nums, int target, int low, int high, IList<IList<int>> fourSumList, int z1)
        {
            if (low + 1 >= high)
                return;

            int max = nums[high];
            if (3 * nums[low] > target || 3 * max < target)
                return;

            int i, z;
            for (i = low; i < high - 1; i++)
            {
                z = nums[i];
                if (i > low && z == nums[i - 1]) // avoid duplicate
                    continue;
                if (z + 2 * max < target) // z is too small
                    continue;

                if (3 * z > target) // z is too large
                    break;

                if (3 * z == target)
                { // z is the boundary
                    if (i + 1 < high && nums[i + 2] == z)
                        fourSumList.Add(new List<int>() { z1,z,z,z});
                    break;
                }

                twoSumForFourSum(nums, target - z, i + 1, high, fourSumList, z1, z);
            }

        }

        public void twoSumForFourSum(int[] nums, int target, int low, int high, IList<IList<int>> fourSumList,
            int z1, int z2)
        {

            if (low >= high)
                return;

            if (2 * nums[low] > target || 2 * nums[high] < target)
                return;

            int i = low, j = high, sum, x;
            while (i < j)
            {
                sum = nums[i] + nums[j];
                if (sum == target)
                {
                    fourSumList.Add(new List<int>() { z1,z2,nums[i],nums[j]});

                    x = nums[i];
                    while (++i < j && x == nums[i]) // avoid duplicate
                        ;
                    x = nums[j];
                    while (i < --j && x == nums[j]) // avoid duplicate
                        ;
                }
                if (sum < target)
                    i++;
                if (sum > target)
                    j--;
            }
            return;
        }


    }
}
