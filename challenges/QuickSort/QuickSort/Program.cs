using System;

namespace QuickSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] unsorted = { 5, 23, 8, 15, 19, 3, 7 };
            Print(unsorted);
            Console.WriteLine("-------");
            QuickSort(unsorted, 0, unsorted.Length - 1);
            Print(unsorted);
            Console.WriteLine("-----");
            Console.ReadKey();

        }

        public static void Print(int[] print)
        {
            for (int i = 0; i < print.Length; i++)
            {
                Console.Write($"{print[i]}, ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// takes in an array, a left bound (0), a right bound (array length -1).
        /// assign those bounds to variables, and then have a "pivot" value that will be 
        /// the index of the median of the bounds. It moves all the values to left or right
        /// of the pivot accordingly. Then it recursively calls itself until everything has been 
        /// sorted
        /// </summary>
        /// <param name="elements">array to be sorted</param>
        /// <param name="left">left bound, 0 at start</param>
        /// <param name="right">right bound, array length-1 at start</param>
        public static void QuickSort(int[] elements, int left, int right)
        {
            int l = left;
            int r = right;
            int pivot = elements[(left + right) / 2];

            while (l <= r)
            {
                while(elements[l].CompareTo(pivot) < 0)
                {
                    l++;
                }
                while (elements[r].CompareTo(pivot) > 0)
                {
                    r--;
                }
                if(l <= r)
                {
                    int swap = elements[l];
                    elements[l] = elements[r];
                    elements[r] = swap;

                    //this shortens the range of things to be sorted around the pivot
                    //each recursion
                    l++;
                    r--;
                }
            }
            if(left < r)
            {
                QuickSort(elements, left, r);
            }
            if(l < right)
            {
                QuickSort(elements, l, right);
            }

        }
    }
}
