using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCode
{
    class Regular_Expression_Matching
    {
        public bool IsMatch(string s, string p)
        {
            var regex = new Regex('^' + p + '$');
            return regex.IsMatch(s);
            //aaab
            //c*a**b  
        }

    }
}
