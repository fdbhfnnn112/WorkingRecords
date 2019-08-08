using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Longest_Common_Prefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
            {
                return "";

            }
            var returnStr = "";
            bool catchStr = true;
            var str = strs.Select(u => u.Length).Min();
            for (int i = 0; i < str; i++)
            {
                catchStr = true;
                var index = strs[0][i];
                for (int j = 1; j < strs.Length; j++)
                {
                    if (strs[j][i] != index)
                    {
                        catchStr = false;
                    }
                }
                returnStr += catchStr?index.ToString():"";
                if (!catchStr)
                {
                    break;
                }
            }

            return returnStr;
        }
    }
}
