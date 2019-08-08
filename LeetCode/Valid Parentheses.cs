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
            try
            {
                Stack<char> signChar = new Stack<char>();

                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                    {
                        signChar.Push(s[i]);
                    }
                    else if (s[i] == ')')
                    {
                        var now = signChar.Pop();
                        if (now == '(')
                        {
                            continue;
                        }
                        return false;
                    }
                    else if (s[i] == ']')
                    {
                        var now = signChar.Pop();
                        if (now == '[')
                        {
                            continue;
                        }
                        return false;
                    }
                    else if (s[i] == '}')
                    {
                        var now = signChar.Pop();
                        if (now == '{')
                        {
                            continue;
                        }
                        return false;
                    }
                }

                if (signChar.Count == 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception er)
            {
                Console.WriteLine("no pop");
                return false;
                    
            }
        }
  
    }
}
