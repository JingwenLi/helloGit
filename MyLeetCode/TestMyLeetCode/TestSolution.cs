using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLeetCode;
using System.Linq;

namespace TestMyLeetCode
{
    [TestClass]
    public class TestSolution
    {
        [TestMethod]
        public void TestMethod260()
        {
            int[] num22s = new int[2];
            int[] nums = { 1, 2, 1, 3, 2, 5 };
            int[] exceptResult = { 3, 5 };
            int[] result = (new Solution260.Solution()).SingleNumber(nums);

            Assert.AreEqual(0, exceptResult.Except(result).Count());
        }

        [TestMethod]
        public void TestMethod334()
        {
           // int[] nums = { 2,4,-2,-3 };
            int[] nums = { 2, 5, 3, 4, 5 };  //true
            bool result = (new Solution334.Solution()).IncreasingTriplet(nums);

            Assert.IsTrue(result);
        }

        [DataTestMethod]
        [DataRow("123", "1234")]
        public void TestMethod3(string a,string b)
        {
            // int[] nums = { 2,4,-2,-3 };
            int[] nums = { 2, 5, 3, 4, 5 };  //true
            bool result = (new Solution334.Solution()).IncreasingTriplet(nums);

            Assert.IsTrue(result);
        }
    }
}
