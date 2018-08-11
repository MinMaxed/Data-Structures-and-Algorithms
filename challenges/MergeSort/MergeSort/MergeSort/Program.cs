using System;

namespace MergeSort
{
    public class Program
    {
        static void Main(string[] args)
        {

            int[] testArr = { 17, 4, 28, 19, 650, 2 };
            Print(testArr);
            Console.WriteLine("-------");
            MergeSort(testArr, 0, testArr.Length-1);
            Print(testArr);
            Console.ReadKey();


        }

        public static int[] MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSort(arr, left, middle);
                MergeSort(arr, middle + 1, right);

                DoMerge(arr, left, middle, right);
            }
            return arr;
        }

        public static void DoMerge(int[] arr, int left, int middle, int right)
        {
            int left2 = middle - left + 1;
            int right2 = right - middle;
            int[] leftArr = new int[left2];
            int[] rightArr = new int[right2];
            int tempLeft = 0;
            int tempRight = 0;
            int k = left;

            for (int i = 0; i < left2; i++)
            {
                leftArr[i] = arr[left + i];
            }

            for (int i = 0; i < right2; i++)
            {
                rightArr[i] = arr[middle + i + 1];
            }

            while(tempLeft < left2 && tempRight < right2)
            {
                if (leftArr[tempLeft] < rightArr[tempRight])
                {
                    arr[k] = leftArr[tempLeft];
                    tempLeft++;
                }
                else
                {
                    arr[k] = rightArr[tempRight];
                    tempRight++;
                }
                k++;
            }

            while (tempLeft < left2)
            {
                arr[k] = leftArr[tempLeft];
                tempLeft++;
                k++;
            }

            while (tempRight < right2)
            {
                arr[k] = rightArr[tempRight];
                tempRight++;
                k++;
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
