using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Reverse_Integer
    {
        public int Reverse(int x)
        {

            var num = x.ToString();
            if (x < 0)
            {
                num = num.Substring(1, num.Length-1);
            }
            num =String.Join("", num.Select(s => s).Reverse());

            try
            {
                return x > 0 ? Convert.ToInt32(num) : Convert.ToInt32(num);
            }
            catch (Exception er)
            {
                return 0;
            }
        }
    }
}
