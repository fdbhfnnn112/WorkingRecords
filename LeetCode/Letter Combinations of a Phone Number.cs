using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Letter_Combinations_of_a_Phone_Number
    {
        Dictionary<char, string> digitsWord = new Dictionary<char, string>() { { '2', "abc" }, { '3', "def" }, { '4', "ghi" }, { '5', "jkl" }, { '6', "mno" }, { '7', "pqrs" }, { '8', "tuv" }, { '9', "wxyz" } };
        public IList<string> LetterCombinations(string digits)
        {
            if (digits == "")
            {
                return new List<string>();
            }
            List<string> words = new List<string>() { ""};
            for (int i = 0; i < digits.Length; i++)
            {
                List<string> lists = new List<string>();
               foreach (char ch in digitsWord[digits[i]])
                {
                    for (int j = 0; j < words.Count; j++)
                    {
                        lists.Add(words[j] +ch);
                    }
                }
                words = lists;
            }

            return words;

        }
    }
}
