using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class String_to_integer__atoi_
    {
        public int MyAtoi(string str)
        {
            var message = str.TrimStart();// str.Replace(" ", "");
            if (message == "" || message == "-" || message == "+")
            {
                return 0;
            }
            bool negative = false;
            if (message[0] == '-'|| message[0] == '+')
            {
                if (message[0] == '-')
                {
                    negative = true;
                }
               message = message.Substring(1, message.Length - 1);
            }
            var i = 0;
            while (47 < message[i] && message[i] < 58)
            {
                i++;
                if (i == message.Length)
                {
                    break;
                }
            }
            message = message.Substring(0, i);
            try
            {
                if (message == "")
                {
                    return 0;
                }
                return negative ? -int.Parse(message) : int.Parse(message);
            }
            catch (Exception er)
            {
                Console.WriteLine("Out the range of 2^32");
                return negative ? (int)-2147483648 : (int)2147483647;
            }

        }

    }
}
