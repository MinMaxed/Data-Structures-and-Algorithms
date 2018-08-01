using System;
using Xunit;
using QuickSort;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestCanSort()
        {

            int[] unsorted = { 5, 23, 8, 15, 19, 3, 7 };      
            Program.QuickSort(unsorted, 0, unsorted.Length - 1);

            Assert.Equal(3, unsorted[0]);
            Assert.Equal(23, unsorted[6]);
            Assert.Equal(8, unsorted[3]);
        }

        [Fact]
        public void TestAlreadySorted()
        {
            int[] unsorted = { 3, 6, 8, 15, 19, 23, 77 };
            Program.QuickSort(unsorted, 0, unsorted.Length - 1);

            Assert.Equal(3, unsorted[0]);
            Assert.Equal(77, unsorted[6]);
            Assert.Equal(15, unsorted[3]);
        }

        [Fact]
        public void TestNegatives()
        {
            int[] unsorted = { -5, 23, 8, -15, 19, 3, 7 };
            Program.QuickSort(unsorted, 0, unsorted.Length - 1);

            Assert.Equal(-15, unsorted[0]);
            Assert.Equal(23, unsorted[6]);
            Assert.Equal(7, unsorted[3]);
        }
    }
}
