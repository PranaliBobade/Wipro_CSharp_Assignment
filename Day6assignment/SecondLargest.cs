// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 12, 23, 37, 24,5 };
        int secondLargest = FirstSecondLargest(arr);

        Console.WriteLine("The second Largest element in array is:"+secondLargest);
        
       

    }
    static int FirstSecondLargest(int[] arr)


    {
        int first, second;
        if (arr.Length < 2)
        {
            throw new ArgumentException("Array length must be at least 2");
        }
        first = second = int.MinValue;
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > first)
                {
                    second = first;
                    first = arr[i];
                }
                else if (arr[i] > second && arr[i] != first)
                {
                    second = arr[i];
                }
            }
            if (second == int.MinValue)
            {
                throw new ArgumentException("All elements are same in the array");
            }
            return second;
        }

    }

}
