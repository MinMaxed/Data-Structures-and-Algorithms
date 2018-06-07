using System;

namespace BinarySearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.ReadLine();

        }

        public static int BinarySearch(int[] sortedArray, int key)
        {
            int noIndex = -1;   
            int i = 0;
            int j = sortedArray.Length - 1;
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
