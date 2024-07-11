// See https://aka.ms/new-console-template for more information
using System;
namespace TrianglePattern
{
    class Prrogram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of Rows");
            int rows = Convert.ToInt32(Console.ReadLine());
            for (int row = 1; row <= rows; row++)
            {
                for(int space = 1; space <= rows - row; space++)
                {
                    Console.Write(" ");
                }
                for(int i = 1; i <= row; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
