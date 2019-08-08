using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _15_3Sum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> L = new List<IList<int>>();
            List<int> numsnum = new List<int>();
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (numbers.ContainsKey(nums[i]))
                {
                    if (numbers[nums[i]] > 3)
                    {
                        continue;
                    }
                    else
                    {
                        numbers[nums[i]] +=1;
                        numsnum.Add(nums[i]);
                    }
                }

                else
                {
                    numbers.Add(nums[i], 1);
                    numsnum.Add(nums[i]);
                }
            }
            nums = numsnum.ToArray();
            Array.Sort(nums);

            List<int> useNum = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (useNum.Contains(nums[i]))
                {
                    continue;
                }
                if (nums[i] > 0)
                {
                    break;
                }
                for (int j = i+1; j < nums.Length; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        if (nums[i] + nums[j] + nums[k] == 0)
                        {
                            List<int> L2 = new List<int>() { nums[i], nums[j], nums[k] };
                            Console.WriteLine("num1 =>" + nums[i] + " num2 =>" + nums[j] + " uum3 =>" + nums[k]);
                            var findItems = from t in L
                                            where t.Except(L2).Count() == 0
                                            select t;

                            var FindS = findItems.ToList();
                            if (FindS.Count== 0)
                            {
                                L.Add(L2);
                            }
                        }
                    }
                }
                useNum.Add(nums[i]);
            }

            return L;
        }

        public IList<IList<int>> threeSum(int[] num)
        {
            Array.Sort(num);
            IList<IList<int>> res= new List<IList<int>>();
            for (int i = 0; i < num.Length - 2; i++)
            {
                if (i == 0 || (i > 0 && num[i] != num[i - 1]))
                {
                    int lo = i + 1, hi = num.Length - 1, sum = 0 - num[i];
                    while (lo < hi)
                    {
                        if (num[lo] + num[hi] == sum)
                        {
                            res.Add(new List<int>() { num[i], num[lo], num[hi] });
                            while (lo < hi && num[lo] == num[lo + 1]) lo++;
                            while (lo < hi && num[hi] == num[hi - 1]) hi--;
                            lo++; hi--;
                        }
                        else if (num[lo] + num[hi] < sum) lo++;
                        else hi--;
                    }
                }
            }
            return res;
        }
    }
}
