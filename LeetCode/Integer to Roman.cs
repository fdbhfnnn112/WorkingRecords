using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Integer_to_Roman
    {
        Dictionary<int, string> Roman = new Dictionary<int, string>() { { 1, "I" }, { 5, "V" }, { 10, "X" }, { 50, "L" }, { 100, "C" }, { 500, "D" }, { 1000, "M" } };
        Dictionary<string, int> RomanInt = new Dictionary<string, int>() { {  "I",1 }, { "V",5 }, {  "X" ,10}, {  "L",50 }, {  "C",100 }, {  "D",500 }, {  "M" ,1000} };
        public string IntToRoman(int num)
        {
            var numText = num.ToString("0000");
            var roman = "";
            for (int i = 0; i < numText.Length; i++)
            {
                var number = (i != 0)?(int) (num / (1000 / (Math.Pow(10,i)))):(int)(num/1000);
                roman += take(number,i);
                num =i!=0?(int) (num % (1000 /Math.Pow(10 , i))):(int)num%1000;
            }

            return roman;
        }

        private string take(int num,int index)
        {
            var retunrStr = "";
            switch(index)
            {
                case 0:
                    for (int i = 0; i < num; i++)
                    {
                        retunrStr += (Roman[1000]);
                    }
                    break;
                case 1:
                    if (num == 4)
                    {
                        retunrStr = Roman[100] + Roman[500];
                    }
                    else if (num == 9)
                    {
                        retunrStr = Roman[100] + Roman[1000];
                    }
                    else if (num < 4)
                    {
                        for (int i = 0; i < num; i++)
                        {
                            retunrStr += Roman[100];
                        }
                    }
                    else if (num > 4)
                    {
                        retunrStr += Roman[500];
                        for (int i = 0; i < num - 5; i++)
                        {
                            retunrStr += Roman[100];
                        }
                    }
                    break;
                case 2:
                    if (num == 4)
                    {
                        retunrStr = Roman[10] + Roman[50];
                    }
                    else if (num == 9)
                    {
                        retunrStr = Roman[10] + Roman[100];
                    }
                    else if (num < 4)
                    {
                        for (int i = 0; i < num; i++)
                        {
                            retunrStr += Roman[10];
                        }
                    }
                    else if (num > 4)
                    {
                        retunrStr += Roman[50];
                        for (int i = 0; i < num - 5; i++)
                        {
                            retunrStr += Roman[10];
                        }
                    }
                    break;
                case 3:
                    if (num == 4)
                    {
                        retunrStr = Roman[1] + Roman[5];
                    }
                    else if (num == 9)
                    {
                        retunrStr = Roman[1] + Roman[10];
                    }
                    else if (num < 4)
                    {
                        for (int i = 0; i < num; i++)
                        {
                            retunrStr += Roman[1];
                        }
                    }
                    else if (num > 4)
                    {
                        retunrStr += Roman[5];
                        for (int i = 0; i < num - 5; i++)
                        {
                            retunrStr += Roman[1];
                        }
                    }
                    break;
            }
            return retunrStr;
        }

        private string nowText =  "";
        public int RomanToInt(string s)
        {
            nowText = s;
            var text = s;
            var returnNum = 0;
            if (checkAndRemove(ref text, "IV"))
            {
                returnNum += 4;
            }
            if (checkAndRemove(ref text, "IX"))
            {
                returnNum += 9;
            }
            if (checkAndRemove(ref text, "XL"))
            {
                returnNum += 40;
            }
            if (checkAndRemove(ref text, "XC"))
            {
                returnNum += 90;
            }
            if (checkAndRemove(ref text, "CD"))
            {
                returnNum += 400;
            }
            if (checkAndRemove(ref text, "CM"))
            {
                returnNum += 900;
            }

            for (int i = 0; i < text.Length; i++)
            {
                returnNum += RomanInt[text[i].ToString()];
            }

            return returnNum;


        }

        private bool checkAndRemove(ref string s, string match)
        {
            if (nowText.Contains(match))
            {
               s =  s.Remove(s.IndexOf(match), 2);
                return true;
            }
            return false;
        }
    }
}
 