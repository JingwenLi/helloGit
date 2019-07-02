using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMyLeetCode
{
    [TestClass]
    public class TestWiseTeach1
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

        public void TestMethod260(string inputStr,string outStr)
        {
            Assert.AreEqual(outStr,(new WiseTeach1()).TransferNums(inputStr).Trim());
        }
    }
}
