using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Container_With_Most_Water
    {
        //violence Varsion
        public int MaxArea(int[] height)
        {
            int Area = 0;
           
            for (int i = 0; i < height.Length; i++)
            {
                var index = height[i];
                for (int j = height.Length - 1; j > i; j--)
                {
                    var num = 0;
                    if (index > height[j])
                    {
                         num = height[j] * (j - i);

                    }
                    else
                    {
                        num = index * (j - i);
                    }
                    if (Area < num)
                    {
                        Area = num;
                    }
                }
            }
            return Area;
        }


        public int MaxAreaEasy(int[] height)
        {
            int area = 0, l = 0, r = height.Length - 1;
            while (l < r)
            {
                area = Math.Max(area, Math.Min(height[l], height[r]) * (r-l));

                if (height[l] < height[r])
                {
                    l++;
                }
                else
                {
                    r--;
                }
            }
            return area;
        }
    }
}
