// See https://aka.ms/new-console-template for more information
using System;
namespace ArrayProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,]
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    Console.Write(matrix[i, j] + " ");


                }
                Console.WriteLine();

            }
        }
    }
}

