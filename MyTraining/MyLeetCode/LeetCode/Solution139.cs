using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLeetCode
{
    public class Solution139
    {
        public class Solution
        {
            public bool WordBreak(string s, IList<string> wordDict)
            {
                int n = s.Length;
                bool[] dp = new bool[n + 1];
                dp[0] = true;
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (dp[j] && wordDict.Contains(s.Substring(j, i-j)))
                        {
                            dp[i] = true;
                            break;        
                        }
                    }
                }
                return dp[n]; 
            }  
        }
    }
}
