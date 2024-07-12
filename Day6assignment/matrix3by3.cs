// See https://aka.ms/new-console-template for more information
using System;
namespace ProgramArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3];
            Console.WriteLine("Enter the elements of the 3*3 matrix:");
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Element [{i},{j}]:");
                    matrix[i, j] = int.Parse(Console.ReadLine());

                    
                }
            }
            Console.WriteLine("\n The 3*3 matrix is:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i,j]+" ");
                   

                }
                Console.WriteLine();
            }


        }
    }
}
