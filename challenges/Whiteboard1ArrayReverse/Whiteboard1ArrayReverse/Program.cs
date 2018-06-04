using System;

namespace Whiteboard1ArrayReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //declare array to be worked on
            int[] newArr = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            //display original array
            Console.Write("OG Arr: ");
            foreach (var num in newArr)
            {
                Console.Write($"{num} ");
            }

            //declare reversed array and display it
            newArr = ReverseArray(newArr);

            Console.Write("\nBackwards Arr: ");
            foreach (var num in newArr)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine("\npress any key to cont: ");
            Console.ReadKey();
        }

        //doing the heavy lifting
        public static int[] ReverseArray(int[] array)
        {
            int[] revArr = new int[array.Length];
            //taking the OG array and putting it into a new, revArr.
            for (int i = 0, j = array.Length - 1; i < revArr.Length; i++, j--)
            {
                revArr[i] = array[j];
            }
            return revArr;
        }
    }

}