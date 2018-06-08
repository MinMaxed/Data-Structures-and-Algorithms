using System;
using BinarySearch;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestKeyPresent()
        {

            int[] testArrayOne = new int[] { 4, 6, 19, 37, 543, 23058234 };
            //int[] testArrayTwo = new int[] { 3, 8, 458, 2394 };

            int testKeyOne = 37;
            //int testKeyTwo = 458;

            Program.BinarySearch(testArrayOne, testKeyOne);
        }

        [Fact]
        public void TestKeyNotPresent()
        {

            int[] testArrayThree = new int[] { 5, 10, 15 };
            int testKeyThree = 17;
            Program.BinarySearch(testArrayThree, testKeyThree);

        }
    }
}
