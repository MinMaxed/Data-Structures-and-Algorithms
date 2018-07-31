using InsertionSort;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestExpected()
        {
            int[] testArr = new int[] { 1, 6, 3, 19, 2, 11, 4 };
            Program.InsertionSort(testArr);
            Assert.Equal(4, testArr[3]);
            Assert.Equal(19, testArr[6]);
            Assert.Equal(1, testArr[0]);
        }

        [Fact]
        public void TestAlreadySorted()
        {
            int[] testArr = new int[] { 1, 2, 5, 19, 22, 111, 444 };
            Program.InsertionSort(testArr);
            Assert.Equal(1, testArr[0]);
            Assert.Equal(19, testArr[3]);
            Assert.Equal(444, testArr[6]);
        }

        [Fact]
        public void TestOne()
        {
            int[] testArr = new int[] { 1 };
            Program.InsertionSort(testArr);
            Assert.Equal(1, testArr[0]);      
        }

        [Fact]
        public void TestNegative()
        {
            int[] testArr = new int[] { 1, 6, -3, 19, 2, 11, -14 };
            Program.InsertionSort(testArr);
            Assert.Equal(-14, testArr[0]);
            Assert.Equal(19, testArr[6]);
            Assert.Equal(1, testArr[2]);
        }
    }
}
