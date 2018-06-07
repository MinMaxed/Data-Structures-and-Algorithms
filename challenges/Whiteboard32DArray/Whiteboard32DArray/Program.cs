using System;

namespace LargestProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        int[,] array2D = new int[,] { { 1, 5, 3 }, { 6, 2, 8 }, { 9, 4, 2 } };
        int Product = 0;

        static int AdjacentProduct()
        {

        }


        static int LargestProduct(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i - 1 >= 0 && j - 1 >= 0)
                    {

                    }
                }
            }
        }
    }
}
