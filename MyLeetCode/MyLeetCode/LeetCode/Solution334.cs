using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLeetCode
{
    //334. 递增的三元子序列

    //给定一个未排序的数组，判断这个数组中是否存在长度为 3 的递增子序列。
    //数学表达式如下:
    //如果存在这样的 i, j, k, 且满足 0 ≤ i<j<k ≤ n-1，
    //使得 arr[i] < arr[j] < arr[k] ，返回 true ; 否则返回 false 。
    //说明: 要求算法的时间复杂度为 O(n)，空间复杂度为 O(1) 。

    //示例 1:
    //    输入: [1,2,3,4,5]
    //    输出: true

    //示例 2:
    //    输入: [5,4,3,2,1]
    //    输出: false

    public class Solution334
    {
        public class Solution
        {
            public bool IncreasingTriplet(int[] nums)
            {
                int? a = null;
                int? b = null;

                for (int i = 0; i < nums.Length; i++)
                {
                    if (i == 0)
                    {
                        a = nums[0];
                        continue;
                    }
                    if (nums[i] < a) {
                        a = nums[i];
                        continue;
                    }
                    if ( a < nums[i] && b == null)
                    {
                        b = nums[i];
                        continue;
                    }
                    if (b != null && nums[i] > a && nums[i] < b )
                    {
                        b = nums[i];
                        continue;
                    }
                    if ( b != null && nums[i] > a  && nums[i] > b) {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
