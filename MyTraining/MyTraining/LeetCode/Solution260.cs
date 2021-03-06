﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace MyTraining.MyLeetCode
{
    //260. 只出现一次的数字 III
    //给定一个整数数组 nums，其中恰好有两个元素只出现一次，其余所有元素均出现两次。 找出只出现一次的那两个元素。

    //示例 :
    //    输入: [1,2,1,3,2,5]
    //    输出: [3,5]

    //注意 :
    //结果输出的顺序并不重要，对于上面的例子， [5, 3]也是正确答案。
    //你的算法应该具有线性时间复杂度。你能否仅使用常数空间复杂度来实现？

    public class Solution260
    {
        public class Solution
        {
            public int[] SingleNumber(int[] nums)
            {
                return nums.GroupBy(x => x).Where(x => x.Count() == 1).Select(x => x.Key).ToArray();
            }
        }
    }


    [TestClass]
    public class TestSolution260
    {
        [TestMethod]
        public void TestMethod()
        {
            int[] num22s = new int[2];
            int[] nums = { 1, 2, 1, 3, 2, 5 };
            int[] exceptResult = { 3, 5 };
            int[] result = (new Solution260.Solution()).SingleNumber(nums);

            Assert.AreEqual(0, exceptResult.Except(result).Count());
        }
    }
}
