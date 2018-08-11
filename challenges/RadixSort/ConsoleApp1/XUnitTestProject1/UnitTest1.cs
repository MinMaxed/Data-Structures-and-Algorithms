using RadixSort;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestUnsortedArray()
        {
            int[] testArr = { 7777, 3, 111, 5, 99, 22, 14, 1111, 55555 };
            Program.RadixSort(testArr);
            int[] checkArr = { 3, 5, 14, 22, 99, 111, 1111, 7777, 55555 };

            Assert.Equal(testArr, checkArr);
        }

        [Fact]
        public void TestSortedArray()
        {
            int[] testArr = { 3, 5, 14, 22, 99, 111, 1111, 7777, 55555 };
            Program.RadixSort(testArr);
            int[] checkArr = { 3, 5, 14, 22, 99, 111, 1111, 7777, 55555 };

            Assert.Equal(testArr, checkArr);
        }

        [Fact]
        public void TestArrayWithOneValue()
        {
            int[] testArr = { 7777 };
            Program.RadixSort(testArr);
            int[] checkArr = { 7777 };

            Assert.Equal(testArr, checkArr);
        }

    }
}
