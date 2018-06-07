using System;

namespace BinarySearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] testArrayOne = new int[] { 4, 6, 19, 37, 543, 23058234 };
            int[] testArrayTwo = new int[] { 3, 8, 458, 2394 };
            int[] testArrayThree = new int[] { 5, 10, 15 };

            int testKeyOne = 37;
            int testKeyTwo = 458;
            int testKeyThree = 17;

            BinarySearch(testArrayOne, testKeyOne);
            BinarySearch(testArrayTwo, testKeyTwo);
            BinarySearch(testArrayThree, testKeyThree);
            Console.ReadLine();

        }

        public static int BinarySearch(int[] sortedArray, int key)
        {
            int noIndex = -1;
            for (int i = 0; i < sortedArray.Length; i++)
            {
                if (sortedArray[i] == key)
                {
                    Console.WriteLine($" key {key} found at {i}");
                    return i;
                }    
            }
            Console.WriteLine($"key {key} not found in array");
              return noIndex;
        }
    }
}
