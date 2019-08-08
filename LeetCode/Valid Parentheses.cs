using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Valid_Parentheses
    {
        public bool IsValid(string s)
        {

            Dictionary<char, char> chars = new Dictionary<char, char>();
            chars.Add(')', '(');
            chars.Add(']', '[');
            chars.Add('}', '{');

            if (s.Length % 2 == 1)
            {
                return false;
            }
            return Middle(s, chars) || StartPoint(s, chars);
        }

        private static bool Middle(string s, Dictionary<char, char> chars)
        {
            try
            {
                var index = 1;
                var StartPoint = s.Length / 2;
                for (int i = StartPoint; i < s.Length; i++)
                {
                    if (chars[s[i]] == s[StartPoint - index])
                    {
                        index++;
                        continue;
                    }
                    return false;
                }
                return true;
            }
            catch (Exception er)
            {
                Console.WriteLine("no match");
                return false;
            }
        }
        private bool StartPoint(string s, Dictionary<char, char> chars)
        {
            try
            {
                for (int i = 0; i < s.Length; i = i + 2)
                {
                    if (chars[s[i + 1]] == s[i])
                    {
                        continue;
                    }
                    return false;
                }
                return true;
            }
            catch (Exception er)
            {
                Console.WriteLine("no match");
                return false;
            }
        }


        public bool Version2ForStach(string s)
        {
            Dictionary<char, char> chars = new Dictionary<char, char>() ;
            chars.Add('(', ')');
            chars.Add('[', ']');
            chars.Add('{', '}');
            Stack<char> STchar = new Stack<char>();
            try
            {
                foreach (var ch in s)
                {
                    if (chars.ContainsValue(ch))
                    {
                        var nowPop = STchar.Pop();
                        if (nowPop == chars.Single(u => u.Value == ch).Key)
                        {
                            continue;
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                    else if (chars.ContainsKey(ch))
                    {
                        STchar.Push(ch);
                        continue;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                return true;
            }
            catch (Exception er)
            {
                Console.WriteLine("Wrong run -> fail test");
                Console.WriteLine(er.Message);
                return false;
            }

          
        }
  
    }
}
