using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyTraining.MyLeetCode
{
    public class Solution11
    {
        public class Solution
        {
            public int MaxArea(int[] height)
            {
                int maxarea = 0;
                for (int i = 0; i < height.Length; i++)
                {
                    for (int j = i + 1; j < height.Length; j++)
                    {
                        maxarea = Math.Max(maxarea, Math.Min(height[i], height[j]) * (j - i));
                    }
                }
                return maxarea;
            }
        }
    }
}
