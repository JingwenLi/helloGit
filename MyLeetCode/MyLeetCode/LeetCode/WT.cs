using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyLeetCode
{
    public class WT
    {
        string[] nums; 

        //数字转英文
        public string TransferNums(string s)
        {
            string result = string.Empty;
            decimal data;

            if (!decimal.TryParse(s, out data))
            {
                Console.WriteLine("Sorry,the number you entered is not validate!");
            }
            else
            {
                s = string.Format("{0:N}", data);
                string dataBeforePoint = s.Split('.')[0];
                string dataAfterPoint = s.Split('.')[1];

                nums = dataBeforePoint.Split(',');

                if (data == 0)
                {
                    result = "zero";
                }
                else
                {
                    if (data < 0)
                    {
                        result = "minus ";
                    }

                    int level = 0;
                    while (level < nums.Length)
                    {
                        result += TransferThreeNums(level);
                        level++;
                    }

                    if (!string.IsNullOrWhiteSpace(dataAfterPoint))
                    {
                        result = result.TrimEnd() + " " + TransferAfterPointNums(dataAfterPoint);
                    }
                }
            }
            return result;
        }

        public string TransferAfterPointNums(string afterPointStr)
        {
            string result = string.Empty;

            if (Convert.ToInt32(afterPointStr) == 0)
            {
                return result;
            }

            for (int i = 0; i < afterPointStr.Length; i++)
            {
                int one = Convert.ToInt32(afterPointStr.ElementAt(i).ToString());
                if (one == 0 && i != afterPointStr.Length - 1)
                {
                    result += "zero";
                }
                else
                {
                    result += TransferSpecialNums(one) + " " ;
                }
            }
            return "point " + result;
        }

        public string TransferThreeNums(int level = 0)
        {
            string result = string.Empty;

            int num = Convert.ToInt32(nums[level]);

            //转化百位
            if (nums[level].Length == 3)
            {
                result += TransferSpecialNums(Convert.ToInt32(nums[level].First().ToString())) + " ";
                if (!string.IsNullOrWhiteSpace(result))
                {
                    result += "hundred" + (num == 100 ? " " : " and ");
                }
            }

            //转化十位
            if (nums[level].Length >= 2)
            {
                if (num % 100 < 20)
                {
                    result += TransferSpecialNums(num % 100) + " "; 
                }
                else
                {
                    result += TransferSpecialNums(num % 100 - num % 10) + " ";
                }
            }

            //转化个位
            //需要转化个位的条件
            //1. 不能被10整除
            //2. 不是【10，20】之内的数
            if (num % 10 != 0 && (num % 100 < 10) || (num % 100 > 20))
            {
                result += TransferSpecialNums(Convert.ToInt32(nums[level].Last().ToString())) + " ";
            }

            //转化基础单位 thousand，million，billion，tillion
            if (!string.IsNullOrWhiteSpace(result) && nums.Length - level - 1 != 0 )
            {
                string baseUnit = TransferSpecialNums(Math.Pow(1000, (nums.Length - level - 1)));
                result += !string.IsNullOrWhiteSpace(baseUnit) ?  baseUnit + " ": "";
            }

            return result;
        }

        /// <summary>
        /// 转换所有可转换的数字为英文
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public string TransferSpecialNums(double a)
        {
            string result = string.Empty;
            switch (a)
            {
                case 1: result = "one"; break;
                case 2: result = "two"; break;
                case 3: result = "three"; break;
                case 4: result = "four"; break;
                case 5: result = "five"; break;
                case 6: result = "six"; break;
                case 7: result = "seven"; break;
                case 8: result = "eight"; break;
                case 9: result = "nine"; break;
                case 10: result = "ten"; break;
                case 11: result = "eleven"; break;
                case 12: result = "twelve"; break;
                case 13: result = "thirteen"; break;
                case 14: result = "fourteen"; break;
                case 15: result = "fifteen"; break;
                case 16: result = "sixteen"; break;
                case 17: result = "seventeen"; break;
                case 18: result = "eighteen"; break;
                case 19: result = "nineteen"; break;
                case 20: result = "twenty"; break;
                case 30: result = "thirty"; break;
                case 40: result = "forty"; break;
                case 50: result = "fourteen"; break;
                case 60: result = "sixty"; break;
                case 70: result = "seventy"; break;
                case 80: result = "eighty"; break;
                case 90: result = "ninety"; break;
                case 1000: result = "thousand"; break;
                case 1000000: result = "million"; break; //一百万
                case 1000000000: result = "billion"; break; //十亿
                case 1000000000000: result = "tillion"; break; //万亿
            }
            return result;
        }
    }


    [TestClass]
    public class TestWT
    {

        [DataTestMethod]

        [DataRow("0", "zero")]
        [DataRow("0.00", "zero")]
        [DataRow("00", "zero")]
        [DataRow("000", "zero")]
        [DataRow("0000", "zero")]

        [DataRow("1", "one")]
        [DataRow("01", "one")]
        [DataRow("001", "one")]
        [DataRow("0001", "one")]

        [DataRow("10", "ten")]
        [DataRow("010", "ten")]
        [DataRow("0010", "ten")]

        [DataRow("19", "nineteen")]
        [DataRow("019", "nineteen")]
        [DataRow("0019", "nineteen")]

        [DataRow("20", "twenty")]
        [DataRow("020", "twenty")]
        [DataRow("0020", "twenty")]

        [DataRow("21", "twenty one")]
        [DataRow("021", "twenty one")]
        [DataRow("0021", "twenty one")]

        [DataRow("49", "forty nine")]
        [DataRow("049", "forty nine")]
        [DataRow("0049", "forty nine")]

        [DataRow("100", "one hundred")]

        [DataRow("110", "one hundred and ten")]
        [DataRow("111", "one hundred and eleven")]
        [DataRow("120", "one hundred and twenty")]
        [DataRow("121", "one hundred and twenty one")]
        [DataRow("990", "nine hundred and ninety")]
        [DataRow("999", "nine hundred and ninety nine")]

        [DataRow("1000", "one thousand")]
        [DataRow("01111", "one thousand one hundred and eleven")]
        [DataRow("001111", "one thousand one hundred and eleven")]
        [DataRow("0001111", "one thousand one hundred and eleven")]
        [DataRow("00000001111", "one thousand one hundred and eleven")]

        [DataRow("1000000000", "one billion")]
        [DataRow("01000000000", "one billion")]
        [DataRow("1000000000000", "one tillion")]
        [DataRow("01000000000000", "one tillion")]

        [DataRow("0.11", "point one one")]
        [DataRow("0.10", "point one")]
        [DataRow("0.22", "point two two")]
        [DataRow("1.22", "one point two two")]
        [DataRow("1000.11", "one thousand point one one")]
        [DataRow("1111.11", "one thousand one hundred and eleven point one one")]
        [DataRow("2000.11", "two thousand point one one")]
        [DataRow("20000.11", "twenty thousand point one one")]
        [DataRow("12000.11", "twelve thousand point one one")]

        [DataRow("1000000.00", "one million")]
        [DataRow("1000000.11", "one million point one one")]
        [DataRow("12000000.11", "twelve million point one one")]

        [DataRow("1000000000.11", "one billion point one one")]
        [DataRow("10000000000.11", "ten billion point one one")]
        [DataRow("12000000000.11", "twelve billion point one one")]

        [DataRow("1000000000000.11", "one tillion point one one")]
        [DataRow("12000000000000.11", "twelve tillion point one one")]

        //case 100000: result = "million"; break;
        //case 1000000000: result = "billion"; break; //十亿
        //case 1000000000000: result = "tillion"; break; //万亿

        public void TestMethod(string inputStr, string outStr)
        {
            Assert.AreEqual(outStr, (new WT()).TransferNums(inputStr).Trim());
        }
    }

}
