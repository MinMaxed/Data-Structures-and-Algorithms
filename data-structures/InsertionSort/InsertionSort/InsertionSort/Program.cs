using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] testArr = new int[] { 1, 6, 3, 19, 2, 11, 4 };

            Print(testArr);
            Console.WriteLine("----------");
            InsertionSort(testArr);
            Print(testArr);
            Console.ReadKey();




        }

        public static int[] InsertionSort(int[] arr)
        {

            for (int i = 1; i < arr.Length; i++)
            {
                int j = i;

                while(arr[j] < arr[j-1])
                {
                    int ln = arr[j - 1];
                    arr[j - 1] = arr[j];
                    arr[j] = ln;
                    j--;
                }
            }
            return arr;
        }

        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{arr[i]}");
            }
        }
    }
}
