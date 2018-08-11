using System;
using Xunit;
using MergeSort;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanSortUnsorted()
        {
            int[] testArr = { 17, 4, 28, 19, 650, 2 };
            Program.MergeSort(testArr, 0, testArr.Length - 1);
            int[] checkArr = { 2, 4, 17, 19, 28, 650 };

            Assert.Equal(checkArr, testArr);

        }

        [Fact]
        public void CanSortSorted()
        {
            int[] testArr = { 1, 4, 8, 9, 65, 200 };
            Program.MergeSort(testArr, 0, testArr.Length - 1);
            int[] checkArr = { 1, 4, 8, 9, 65, 200 };

            Assert.Equal(checkArr, testArr);

        }

        [Fact]
        public void CanSortWithNegatives()
        {
            int[] testArr = { 17, -4, 28, -19, 650, 2 };
            Program.MergeSort(testArr, 0, testArr.Length - 1);
            int[] checkArr = { -19, -4, 2, 17, 28, 650 };

            Assert.Equal(checkArr, testArr);
        }

        [Fact]
        public void CanSortWithOneValue()
        {
            int[] testArr = { 17 };
            Program.MergeSort(testArr, 0, testArr.Length - 1);
            int[] checkArr = { 17 };

            Assert.Equal(checkArr, testArr);
        }
    }
}
