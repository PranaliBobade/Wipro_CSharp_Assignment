// See https://aka.ms/new-console-template for more information

using System;
using System.Reflection;
namespace NumberTodigit
{
    class NumberTodigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            string number = Console.ReadLine().Trim();
            string[] digitToWords = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };

            for (int i = 0; i < number.Length; i++)
            {
                char digit = number[i];
                int index = digit - '0';
                if (index >= 0 && index <= 9)
                {

                    Console.WriteLine(digitToWords[index] + " ");
                }
            }
           
        }
    }
}

