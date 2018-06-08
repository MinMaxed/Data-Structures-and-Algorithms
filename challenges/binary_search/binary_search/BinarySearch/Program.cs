using System;

namespace BinarySearch
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int[] testArray = new int[] { 4, 8, 15, 16, 23, 42};
            int[] testArray2 = new int[] { 11, 22, 33, 44, 55, 66, 77 };

            Console.WriteLine("Hello World!");
            BinarySearch(testArray, 9);
            Console.ReadLine();

        }

        public static int BinarySearch(int[] sortedArray, int key)
        {
            int noIndex = -1;
            int min = 0;
            int max = sortedArray.Length - 1;

            while (min <= max)
            {

                int mid = (max + min) / 2;
                if (key == sortedArray[mid])
                {
                    Console.WriteLine($" key {key} found at {sortedArray[mid]}");
                    return mid;
                }
                else if (key < sortedArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            Console.WriteLine($" key {key} was not found.");
            return noIndex;
        }
    }
}

