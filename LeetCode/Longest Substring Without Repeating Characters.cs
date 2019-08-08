using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Longest_Substring_Without_Repeating_Characters
    {
        public int LengthSubstring(string s)
        {
            string returnStr = "";
            string LongestStr = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (!LongestStr.Contains(s[i]))
                {
                    LongestStr += s[i];
                }
                else
                {
                    if (LongestStr.Length > returnStr.Length)
                    {
                        returnStr = LongestStr;
                    }
                    var index = LongestStr.IndexOf(s[i])+1;
                    LongestStr = LongestStr.Substring(index, LongestStr.Length -index) + s[i];
                }
            }
            
            return returnStr.Length>LongestStr.Length?returnStr.Length:LongestStr.Length;
        }
        public int Lenght(string s)
        {
            string chr = s[0].ToString();
            int max = 1;
            int now = 1;
            for (int i = 0; i < s.Length-1; i++)
            {
                chr = s[i].ToString();
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (chr.Contains(s[j]))
                    {
                        if (max <= now)
                        {
                            max = now;
                        }
                        now = 1;
                        break;

                    }
                    else
                    {
                        chr += s[j];
                        now++;
                        if (j == s.Length-1)
                        {
                            if (max <= now)
                            {
                                max = now;
                            }
                            now = 1;
                        }
                    }
                }
            }
            if (now > max)
            {
                max = now;
            }
            return max;
        }

        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 0)
            {
                return 0;
            }
            var max = 1;
            var now = 1;
            var NowStr = s[0].ToString();
            for (int i = 1; i < s.Length; i++)
            {
                if (!NowStr.Contains(s[i]))
                {
                    now++;
                    NowStr += s[i];
                }
                else
                {
                    
                    if (max <= now)
                    {
                        max = now;
                        now = 1;
                    }
                    if (NowStr[NowStr.Length-1] != s[i])
                    {
                        NowStr = s[i - 1].ToString();
                        i--;
                    }
                    else
                    {
                        NowStr = s[i].ToString();
                    }
                    
                   
                }
            }

            if (max < now)
            {
                max = now;
            }
            return max;

        }

    }
}