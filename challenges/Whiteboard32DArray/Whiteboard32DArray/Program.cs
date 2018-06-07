using System;

namespace LargestProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        int[][] myArray = new int[][]
        {
            new int[] {4, 8, 20},
            new int[] {7, 16, 3},
            new int[] {19, 17, 12}
        };


        int[,] array2D = new int[,]
        {
            { 1, 5, 3 },
            { 6, 2, 8 },
            { 9, 4, 7 }
        };


        int Product = 0;

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



        static int AdjacentProduct(int[][] matrix)
        {


            //multiply position 0,0 by position 0, 1, so the first two numbers in the bigger array's 0 index array....
            int max = matrix[0][0] * matrix[0][1];

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (i < matrix.Length - 1 && matrix[i][j] * matrix[i + 1][j] > max)
                    {
                        max = matrix[i][j] * matrix[i + 1][j];
                    }

                    if (j < matrix[i].Length - 1 && matrix[i][j] * matrix[i][j + 1] > max)
                    {
                        max = matrix[i][j] * matrix[i][j + 1];
                    }


                }
            }

        }




    }
}
