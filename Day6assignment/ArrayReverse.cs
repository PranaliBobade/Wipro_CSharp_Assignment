using System;

class Program
{
    static void Main()
    {
        string[] ar = { "Books", "Pens", "Charts" };

     
        string result = ConvertToCsv(ar);

  
        Console.WriteLine($"Output: {result}");

        Console.ReadLine();
    }

    static string ConvertToCsv(string[] array)
    {
        if (array == null || array.Length == 0)
        {
            return ""; 
        }

        string csvString = array[0]; 

       
        for (int i = 1; i < array.Length; i++)
        {
            csvString += ", " + array[i];
        }

        return csvString;
    }
}
