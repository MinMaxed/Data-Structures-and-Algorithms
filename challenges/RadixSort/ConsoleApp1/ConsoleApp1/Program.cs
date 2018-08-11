using System;

namespace RadixSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] testArr = { 7777, 3, 111, 5, 99, 22, 14, 1111, 55555 };
            Print(testArr);
            Console.WriteLine("-----");
            RadixSort(testArr);
            Print(testArr);
            Console.ReadKey();

        }
        /// <summary>
        /// takes in an array and sorts it
        /// </summary>
        /// <param name="arr">input array</param>
        /// <returns>sorted array</returns>
        public static int[] RadixSort (int[] arr)
        {
            int me = GetMe(arr);

            for (int exp = 1; me/exp > 0; exp*=10)
            {
                CountSort(arr, exp);
            }

            return arr;
        }

        /// <summary>
        /// Gets the max value in the array 
        /// </summary>
        /// <param name="arr">input array</param>
        /// <returns>max value</returns>
        public static int GetMe(int[] arr)
        {
            int me = arr[0];
            foreach (var item in arr)
            {             
                if(item > me)
                {
                    me = item;
                }
            }
            return me;
        }

        /// <summary>
        /// takes in an array and a digits spot and then sorts based on the digits of the array values
        /// </summary>
        /// <param name="array">array to be sorted</param>
        /// <param name="digit">digits spot</param>
        public static void CountSort(int[] array, int digit)
        {
            int[] output = new int[array.Length];
            int i;
            int[] count = new int[10];

            for (i = 0; i < array.Length; i++)
            {
                int z = (array[i] / digit) % 10;
                count[z]++;
            }

            for (i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            for (i = array.Length - 1; i >= 0; i--)
            {
                int z = (array[i] / digit) % 10;
                int y = count[z] - 1;
                output[y] = array[i];
                count[z]--;
            }

            for (i = 0; i < array.Length; i++)
            {
                array[i] = output[i];
            }
        }

        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ",");
            }
            Console.WriteLine();
        }
    }
}
