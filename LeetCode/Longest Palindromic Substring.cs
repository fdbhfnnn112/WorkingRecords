using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Longest_Palindromic_Substring
    {

        private string checkSame(string Source, int index,int Start)
        {
            if (index - Start - 1 < 0 || index + Start + 1 > Source.Length - 1)
            {
                 return Source.Substring(index - Start, Start * 2+1);
            }

            else
            {
                if (Source[index - Start - 1] == Source[index + Start + 1])
                {
                   return checkSame(Source, index, Start + 1);
                }
                else
                {
                    return Source.Substring(index - Start, Start * 2+1);
                }
            }
        }
        public string LongestPalindrome(string s)
        {
            string returnStr = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (i == 0)
                {
                    if (s[i + 1] == s[i])
                    {
                        if (returnStr.Length < 2)
                        {
                            returnStr = s.Substring(0, 2);
                        }
                    }
                }

                else if (i == s.Length - 1)
                {
                    if (s[i] == s[i - 1])
                    {
                        if (returnStr.Length < 2)
                        {
                            returnStr = s.Substring(s.Length - 2, 2);
                        }
                    }
                }

                else
                {
                    if (s[i - 1] == s[i] && s[i + 1] == s[i])
                    {
                        var GetStr = checkSame(s, i, 0);
                        if (GetStr.Length > returnStr.Length)
                        {
                            returnStr = GetStr;
                        }
                    }

                    else if (s[i - 1] == s[i] || s[i + 1] == s[i])
                    {
                        if (returnStr.Length < 2)
                        {
                            returnStr = s[i].ToString() + s[i].ToString();
                        }
                    }
                    else
                    {
                        var GetStr = checkSame(s, i, 0);
                        if (GetStr.Length > returnStr.Length)
                        {
                            returnStr = GetStr;
                        }
                    }

                }
            }

            return returnStr;
        }

        public string LongPalind(string s)
        {
            if (s.Length == 1)
            {
                return s;
            }

            string returnStr = "";
            string continuous = "";
            for (int i = 0; i < s.Length; i++)
            {
                var Left = i-CheckLeft(s,i,0);
                var Right = CheckRight(s, i, 0);
                if ((Right - Left) % 2 == 0)
                {
                    continuous=  CheckOdd(s, i, 0);
                }
                else
                {
                    continuous = CheckEven(s, Left, Right);
                }

                returnStr = continuous.Length > returnStr.Length ? continuous : returnStr;
            }

            return returnStr;
        }


        private int CheckLeft(string source, int index,int Start)
        {
            if (index > 0)
            {
                if (index - Start - 1 < 0)
                {
                    return Start;
                }
                if (source[index] == source[index - Start - 1])
                {
                    return CheckLeft(source, index, Start + 1);
                }
                else
                {
                    return Start;
                }
            }

            return 0;
        }


        private int CheckRight(string source, int index, int Start)
        {
            int length = source.Length-1;
            if (index < length)
            {
                if (index + Start + 1 > length)
                {
                    return Start;
                }
                if (source[index] == source[index + Start + 1])
                {
                    return CheckRight(source, index, Start + 1);
                }
                else
                {
                    return Start;
                }
            }

            return length;
        }

        private string CheckOdd(string source, int index, int start)
        {
            if (index - start - 1 < 0 || index + start + 1 >= source.Length)
            {
                return source.Substring(index - start, (start * 2) +1);
            }
            else
            {
                if (source[index - start - 1] == source[index + start + 1])
                {
                    return CheckOdd(source, index, start + 1);
                }
                else
                {
                   return  source.Substring(index - start, start * 2);
                }
            }
        }

        private string CheckEven(string source, int IndexStart, int IndexEnd)
        {
            if (IndexStart - 1 < 0 || IndexEnd + 1 > source.Length - 1)
            {
                return source.Substring(IndexStart, IndexEnd - IndexStart);
            }
            else
            {
                if (source[IndexStart - 1] == source[IndexEnd + 1])
                {
                    return CheckEven(source, IndexStart - 1, IndexEnd + 1);
                }
                else
                {
                    return source.Substring(IndexStart, IndexEnd - IndexStart);
                }
            }
        }

        
    }
}
