using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLeetCode
{
    public class Solution5
    {
        public class Solution
        {
            public string LongestPalindrome(string s)
            {
                return string.Empty;
            }


            //马拉车法 超时
            public string LongestPalindromeV2(string s)
            {
                if (string.IsNullOrEmpty(s))
                {
                    return string.Empty;
                }

                char?[] charwords = new char?[s.Length + s.Length + 1];

                for (int i = 0; i < s.Length; i++)
                {
                    charwords[2 * i + 1] = s.ElementAt(i);
                }

                string[] store = new string[charwords.Length];

                for (int i = 1; i < charwords.Length - 1 ; i++)
                {
                    int length = 0;
                    string res = charwords[i].ToString();
                    for (int j = 1; j <= i && i + j < charwords.Length && i - j >= 0 ; j++)
                    {
                        if (charwords[i + j] == charwords[i - j])
                        {
                            res = charwords[i - j] + res + charwords[i + j];
                            store[length] = res;
                            length++;

                            if (i == s.Length && j == s.Length)
                            {
                                return res;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                return store.OrderBy(x => x?.Length).Last();
            }
        }
    }
}
