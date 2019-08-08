using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class ZigZag_Conversion
    {
        public string Convert(string s, int numRows)
        {
            if (s.Length == 0)
            {
                return "";
            }
            if (numRows == 1)
            {
                return s;

            }
            List<string> Message = new List<string>(new string[numRows]);
            for (int i = 0; i < (s.Length / (2 * numRows - 2)) + 1; i++)
            {
                var FirstNum = (numRows + numRows - 2) * i;
                Message[0] += CheckIndex(FirstNum, s);
                Message[numRows - 1] += CheckIndex(FirstNum + numRows - 1, s);
                for (int Index = 1; Index < numRows - 1; Index++)
                {
                    var num = FirstNum + Index;
                    Message[Index] += CheckIndex(num, s);//s[num];
                    Message[Index] += CheckIndex(num + (2 * (numRows - Index - 1)), s);
                }
            }
            var returnStr = "";
            for (int numList = 0; numList < Message.Count; numList++)
            {
                returnStr += Message[numList];
            }

            return returnStr.Replace(" ", "");

        }
        private char CheckIndex(int index, string s)
        {
            try
            {
                return s[index];
            }
            catch (Exception er)
            {
                Console.WriteLine("index error");
                return ' ';
            }
        }


    }
}
