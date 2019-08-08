using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Palindrome_Number
    {
        public bool IsPalindrome(int x)
        {
            var str = x.ToString();
            var rev = String.Join("", str.Select(j => j).Reverse());
            return str == rev ? true : false;
        }
    }
}
