using System;

namespace InsertionSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] testArr = new int[] { 1, 6, 3, 19, 2, 11, 4 };
            int[] testArr2 = new int[] { 1, 6, -3, 19, 2, 11, -14 };
            int[] testArr3 = new int[] { 1, 2, 5, 19, 22, 111, 444 };

            Print(testArr);
            //Console.WriteLine("----------");
            //InsertionSort(testArr);
            //Print(testArr);
            Console.WriteLine("----------");
            InsertionSort(testArr3);
            Print(testArr3);
            Console.ReadKey();




        }

        //sort based on wiki
        public static int[] InsertionSort2(int[] arr, int n)
        {
            if (n > 0)
            {
                InsertionSort2(arr, n - 1);
                int x = arr[n];
                int j = n - 1;
                while ( j >= 0 && arr[j] > x)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = x;               
            }
            return arr;
        }


        //sort based on my own research
        public static int[] InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i;
                while ((j > 0) && (arr[j] < arr[j - 1]))
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
